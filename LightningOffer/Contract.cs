using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Authenticators;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Kernel.Geom;
using System.IO;

namespace LightningOffer
{
    public class Contract
    {
        public DateTime OfferDate { get; set; }
        public int mlsNum { get; set; }
        public int purchasePrice { get; set; }
        public string applyForLoan { get; set; }
        public string financing { get; set; }
        public bool sellerDisclosureReceived { get; set; }
        public bool leadPaintBuiltBefore1978 { get; set; }
        public bool leadPaintNotReceived { get; set; }
        public int leadPaintTimeToInspect { get; set; }
        public int leadPaintTimeToRespond { get; set; }
        public bool inspectionAcceptAsIs { get; set; }
        public bool inspectionInspect { get; set; }
        public int inspectionInspectTimeLine { get; set; }
        public int inspectionInspectSellerResponseTime { get; set; }
        public int inspectionInspectBuyerResponseTime { get; set; }
        public int inspectionInspectFinalDeadLine { get; set; }
        public bool contingentOnSurvey { get; set; }
        public string contingentOnSurveyTimeLine { get; set; }
        public DateTime closingDateSpecific { get; set; }
        public int closingDateRangeStart { get; set; }
        public int closingDateRangeClose { get; set; }
        public bool leaseNotExisting { get; set; }
        public bool leaseExisting { get; set; }
        public bool titleInsurance { get; set; }
        public string listAgentSignature { get; set; }
        public string buyerAgentSignature { get; set; }
        public string otherProvisions { get; set; }
        public string buyerPrintedName { get; set; }
        public string buyerSignature { get; set; }
        public DateTime buyerDateTimeSigned { get; set; }



        public static void BeginOffer()
        {
 
        }

    }


}

