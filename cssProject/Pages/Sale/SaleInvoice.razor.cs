using AppliedReporting;
using cssProject.Data;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.VisualBasic;
using System.Data;
using System.Threading.Tasks.Dataflow;

namespace cssProject.Pages.Sale
{
    public partial class SaleInvoice
    {


        public DataTable View_SalesInvoice { get; set; } = new();
        public SaleInvoiceModel Model { get; set; } = new();
        public SaleInvoiceRecord Record { get; set; } = new();
        public ReportModel Printmodel { get; set; } = new();


        #region Sale Invoice

        public class SaleInvoiceModel
        {
            #region Variables
            //public AppUserModel UserProfile { get; set; }
            //public DataSource Source { get; set; }
            public string InvoiceNo { get; set; } = string.Empty;
            public DataTable View_SalesInvoice { get; set; } = new();
            public SaleInvoiceRecord SaleInvoiceRecord { get; set; } = new();
            public List<SaleInvoiceRecord> SaleInvoiceRecords { get; set; } = GetSaleInvoiceRecords();

            private static List<SaleInvoiceRecord> GetSaleInvoiceRecords()
            {
                var _List = new List<SaleInvoiceRecord>()
                {
                    new SaleInvoiceRecord() {
                        TitleInventory = "Stock1",
                        Batch="B-001",
                        Qty = 10,
                        Rate = 4.50M,
                        Comments = "Comments",
                        Ref_No = "Ref123",
                        Employee = 0,
                        Company = 0,
                        Inventory = 0,
                        Unit = 0,
                        TitleCompany = "",
                        TitleEmployee = "",
                        TitleProject = "",
                        TitleTaxID = "",
                        TitleUnit = "",
                        ID1 = 0,
                        ID2 = 0,
                        TaxID = 0,
                        TaxRate = 13,
                        TranID = 0,
                        Description = "",
                        Inv_Date = DateTime.Now,
                        Pay_Date = DateTime.Now,
                        Vou_Date = DateTime.Now,
                        Vou_No = "SL0000-0000",
                        Inv_No = "INV003",
                        Project = 0,
                        Remarks = "",
                        Sr_No = 1,
                        Status = "Submitted"
                    },
                    new SaleInvoiceRecord() {
                        TitleInventory = "Stock1",
                        Batch="B-001",
                        Qty = 10,
                        Rate = 4.50M,
                        Comments = "Comments",
                        Ref_No = "Ref123",
                        Employee = 0,
                        Company = 0,
                        Inventory = 0,
                        Unit = 0,
                        TitleCompany = "",
                        TitleEmployee = "",
                        TitleProject = "",
                        TitleTaxID = "",
                        TitleUnit = "",
                        ID1 = 0,
                        ID2 = 0,
                        TaxID = 0,
                        TaxRate = 13,
                        TranID = 0,
                        Description = "",
                        Inv_Date = DateTime.Now,
                        Pay_Date = DateTime.Now,
                        Vou_Date = DateTime.Now,
                        Vou_No = "SL0000-0000",
                        Inv_No = "INV003",
                        Project = 0,
                        Remarks = "",
                        Sr_No = 1,
                        Status = "Submitted"
                    },
                    new SaleInvoiceRecord() {
                        TitleInventory = "Stock1",
                        Batch="B-001",
                        Qty = 10,
                        Rate = 4.50M,
                        Comments = "Comments",
                        Ref_No = "Ref123",
                        Employee = 0,
                        Company = 0,
                        Inventory = 0,
                        Unit = 0,
                        TitleCompany = "",
                        TitleEmployee = "",
                        TitleProject = "",
                        TitleTaxID = "",
                        TitleUnit = "",
                        ID1 = 0,
                        ID2 = 0,
                        TaxID = 0,
                        TaxRate = 13,
                        TranID = 0,
                        Description = "",
                        Inv_Date = DateTime.Now,
                        Pay_Date = DateTime.Now,
                        Vou_Date = DateTime.Now,
                        Vou_No = "SL0000-0000",
                        Inv_No = "INV003",
                        Project = 0,
                        Remarks = "",
                        Sr_No = 1,
                        Status = "Submitted"
                    },
                    new SaleInvoiceRecord() {
                        TitleInventory = "Stock1",
                        Batch="B-001",
                        Qty = 10,
                        Rate = 4.50M,
                        Comments = "Comments",
                        Ref_No = "Ref123",
                        Employee = 0,
                        Company = 0,
                        Inventory = 0,
                        Unit = 0,
                        TitleCompany = "",
                        TitleEmployee = "",
                        TitleProject = "",
                        TitleTaxID = "",
                        TitleUnit = "",
                        ID1 = 0,
                        ID2 = 0,
                        TaxID = 0,
                        TaxRate = 13,
                        TranID = 0,
                        Description = "",
                        Inv_Date = DateTime.Now,
                        Pay_Date = DateTime.Now,
                        Vou_Date = DateTime.Now,
                        Vou_No = "SL0000-0000",
                        Inv_No = "INV003",
                        Project = 0,
                        Remarks = "",
                        Sr_No = 1,
                        Status = "Submitted"
                    },
                    new SaleInvoiceRecord() {
                        TitleInventory = "Stock1",
                        Batch="B-001",
                        Qty = 10,
                        Rate = 4.50M,
                        Comments = "Comments",
                        Ref_No = "Ref123",
                        Employee = 0,
                        Company = 0,
                        Inventory = 0,
                        Unit = 0,
                        TitleCompany = "",
                        TitleEmployee = "",
                        TitleProject = "",
                        TitleTaxID = "",
                        TitleUnit = "",
                        ID1 = 0,
                        ID2 = 0,
                        TaxID = 0,
                        TaxRate = 13,
                        TranID = 0,
                        Description = "",
                        Inv_Date = DateTime.Now,
                        Pay_Date = DateTime.Now,
                        Vou_Date = DateTime.Now,
                        Vou_No = "SL0000-0000",
                        Inv_No = "INV003",
                        Project = 0,
                        Remarks = "",
                        Sr_No = 1,
                        Status = "Submitted"
                    },
                };


                return _List;
            }

            public bool IsRecordLoaded { get; set; }
            public SaleInvoiceTotal Totals { get; set; } = new();
            public bool ShowDigits { get; set; } = true;

            public List<CodeTitle> CodeTitleList { get; set; } = GetCodeTitleList();
            public List<CodeTitle> Customers { get; set; } = GetCodeTitleList();
            public List<CodeTitle> Employees { get; set; } = GetCodeTitleList();
            public List<CodeTitle> Projects { get; set; } = GetCodeTitleList();
            public List<CodeTitle> Inventory { get; set; } = GetCodeTitleList();
            public List<CodeTitle> Taxes { get; set; } = GetCodeTitleList();
            public List<CodeTitle> Units { get; set; } = GetCodeTitleList();
           

            //public AppMessages Messages { get; set; } = new();

            private static List<CodeTitle> GetCodeTitleList()
            {
                var _List = new List<CodeTitle>()
                {
                new() { ID = 1, Code = "101", Title = "Title 1" },
                new() { ID = 2, Code = "102", Title = "Title 2" },
                new() { ID = 3, Code = "103", Title = "Title 3" },
                new() { ID = 4, Code = "104", Title = "Title 4" },
                new() { ID = 5, Code = "105", Title = "Title 5" },

            }; return _List;
            }

            public string NumberFormat { get; set; } = ""; //Formats.TwoDigits;
            public string DateFormat { get; set; } = ""; //Formats.ddMMMyyyy;

            #endregion

            #region Convert decimal to String Text
            public string ToAmount(object _Object)
            {
                return Data.Conversion.ToAmount(_Object, NumberFormat);
            }
            #endregion
        }
        public class SaleInvoiceRecord
        {
            public SaleInvoiceRecord() { }
            public int ID1 { get; set; }
            public int ID2 { get; set; }
            public string Vou_No { get; set; } = string.Empty;
            public string Ref_No { get; set; } = string.Empty;
            public string Inv_No { get; set; } = string.Empty;
            public int TranID { get; set; }
            public int Sr_No { get; set; }
            public int Inventory { get; set; }
            public int Company { get; set; }
            public int Employee { get; set; }
            public int Project { get; set; }
            public int TaxID { get; set; }


            public string TitleInventory { get; set; } = string.Empty;
            public string TitleCompany { get; set; } = string.Empty;
            public string TitleEmployee { get; set; } = string.Empty;
            public string TitleProject { get; set; } = string.Empty;
            public string TitleTaxID { get; set; } = string.Empty;
            public string TitleUnit { get; set; } = string.Empty;

            public DateTime Vou_Date { get; set; }
            public DateTime Inv_Date { get; set; }
            public DateTime Pay_Date { get; set; }

            public string Remarks { get; set; } = string.Empty;
            public string Comments { get; set; } = string.Empty;
            public string Description { get; set; } = string.Empty;
            public string Batch { get; set; } = string.Empty;
            public string Status { get; set; } = string.Empty;

            public int Unit { get; set; }
            public decimal Qty { get; set; } = 0.00M;
            public decimal Rate { get; set; } = 0.00M;
            public decimal TaxRate { get; set; } = 0.00M;
            public decimal Amount => decimal.Parse((Qty * Rate).ToString());
            public decimal TaxAmount => decimal.Parse((Amount * (TaxRate / 100)).ToString());
            public decimal NetAmount => decimal.Parse((Amount + TaxAmount).ToString());

        }
        public class SaleInvoiceTotal
        {
            public string NumberFormat { get; set; } = "#,##0.00";
            public decimal Tot_Qty { get; set; } = 0.00M;
            public decimal Tot_Amount { get; set; } = 0.00M;
            public decimal Tot_TaxAmount { get; set; } = 0.00M;
            public decimal Tot_NetAmount { get; set; } = 0.00M;
        }

        public void ValueChanged()
        {

        }

        public void ClickMe()
        {

        }


        #endregion

        #region Methods
        public void Submit()
        { }
        private void New(MouseEventArgs e)
        {

        }
        private void Update(MouseEventArgs e)
        {

        }
        private void First(MouseEventArgs e)
        {

        }
        private void Next(MouseEventArgs e)
        {

        }
        private void Back(MouseEventArgs e)
        {

        }
        private void Last(MouseEventArgs e)
        {

        }
        private void Save(MouseEventArgs e)
        {

        }
        #endregion
        public void Digits()
        {
            if (Model.ShowDigits)
            {
                Model.NumberFormat = "#,##0";
            }
            else
            {
                Model.NumberFormat = "#,##0.00";
            }
            //Model.SetTotals();
        }

    }
}

