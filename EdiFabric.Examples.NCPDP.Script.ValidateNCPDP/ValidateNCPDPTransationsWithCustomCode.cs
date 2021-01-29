using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using EdiFabric.Core.Annotations.Edi;
using EdiFabric.Core.Annotations.Validation;
using EdiFabric.Core.ErrorCodes;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Core.Model.Edi.Ncpdp;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.Script106;

namespace EdiFabric.Examples.NCPDP.Script.ValidateNCPDP
{
    class ValidateNCPDPTransationsWithCustomCode
    {
        /// <summary>
        /// Apply custom validation for cross segment or data element scenarios
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ncpdpStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\PrescriptionRequest_NEWRX.txt");

            List<IEdiItem> ncpdpItems;
            using (var ncpdpReader = new NcpdpScriptReader(ncpdpStream, (UIB uib, UIH uih) => typeof(TSNEWRXCustom).GetTypeInfo()))
                ncpdpItems = ncpdpReader.ReadToEnd().ToList();

            var prescriptionRequest = ncpdpItems.OfType<TSNEWRXCustom>().Single();

            //  Check that the custom validation was triggered
            MessageErrorContext errorContext;
            if (!prescriptionRequest.IsValid(out errorContext))
            {
                var customValidation = errorContext.Errors.FirstOrDefault(e => e.Message == "SIG segment is missing.");
                Debug.WriteLine(customValidation.Message);
            }
        }
    }

    /// <summary>
    /// New validation attribute to apply to DRU loops
    /// Validates that if DRU segment exists, then SIG segment must also exists, otherwise throws an exception
    /// Preserves the position of the missing segment within the loop, to allow the correct index to be applied in the acknowledgment
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class DRULoopValidationAttribute : ValidationAttribute
    {
        public DRULoopValidationAttribute() : base(10)
        {
        }

        public override SegmentErrorContext ValidateEdi(ValidationContext validationContext)
        {
            var position = validationContext.SegmentIndex + 1;

            var druLoop = validationContext.InstanceContext.Instance as Loop_DRU_TSNEWRX;
            if (druLoop != null)
            {
                //  Check if DRU exists and SIG also exist
                    if (druLoop.DRU != null && druLoop.SIG == null)
                        return new SegmentErrorContext("SIG", validationContext.SegmentIndex + 1, null, GetType().GetTypeInfo(), SegmentErrorCode.RequiredSegmentMissing,
                            "SIG segment is missing.");                
            }

            return null;
        }
    }

    [Message("SCRIPT", "NEWRX")]
    public class TSNEWRXCustom : TSNEWRX
    {
        [DRULoopValidation]
        [DataMember]
        [Pos(6)]
        [Required]
        public new Loop_DRU_TSNEWRX DRULoop { get; set; }
    }
}
