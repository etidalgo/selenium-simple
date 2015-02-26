namespace Originator.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DLRMAST")]
    public partial class DLRMAST
    {
        [Key]
        [Column("Dealer Number")]
        [StringLength(12)]
        public string Dealer_Number { get; set; }

        [StringLength(6)]
        public string FINNOW { get; set; }

        [Column("Dealer Name")]
        [StringLength(50)]
        public string Dealer_Name { get; set; }

        [Column("Dealer Group")]
        [StringLength(50)]
        public string Dealer_Group { get; set; }

        [Column("Street Address")]
        [StringLength(50)]
        public string Street_Address { get; set; }

        [StringLength(50)]
        public string Suburb { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [Column("Postal Address")]
        [StringLength(150)]
        public string Postal_Address { get; set; }

        [Column("Telephone Number")]
        [StringLength(50)]
        public string Telephone_Number { get; set; }

        [Column("Fax Number")]
        [StringLength(50)]
        public string Fax_Number { get; set; }

        [Column("Goods Sold")]
        [StringLength(50)]
        public string Goods_Sold { get; set; }

        [StringLength(50)]
        public string Manager { get; set; }

        [Column("Customer Rate")]
        public double? Customer_Rate { get; set; }

        [Column("Dealer Base Rate")]
        public double? Dealer_Base_Rate { get; set; }

        [Column("Commission Rate")]
        public double? Commission_Rate { get; set; }

        [Column("PPI Rate")]
        [StringLength(50)]
        public string PPI_Rate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecNum { get; set; }

        public byte? Tag { get; set; }

        [StringLength(8)]
        public string Dlr_Type { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        public bool Active { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Web_LastSeen { get; set; }

        [StringLength(50)]
        public string Dlr_Book_Fee_Code { get; set; }

        public int? Cmr_Book_Fee_Rate { get; set; }

        public int? Score_Min { get; set; }

        public int? Amount_Max { get; set; }

        [StringLength(4)]
        public string Contracts_Utild { get; set; }

        public int? Max_Term { get; set; }

        public int? Max_Def_Term { get; set; }

        public double? Deposit_Percent { get; set; }

        public bool Web_Lock { get; set; }

        [StringLength(4)]
        public string Acc_Mgr_ID { get; set; }

        public bool No_Override { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Dlr_Since { get; set; }

        [StringLength(100)]
        public string EMail { get; set; }

        public byte? Pref_Cont_Meth { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Trail_Rate { get; set; }

        [StringLength(25)]
        public string Bank_Acc_No { get; set; }

        [StringLength(50)]
        public string Bank_Acc_Name { get; set; }

        [StringLength(20)]
        public string Mobile_Tel { get; set; }

        public bool Org_Cont_Held { get; set; }

        public bool IsGroupHead { get; set; }

        public DateTime Date_Modified { get; set; }

        public bool Disable_BookFee_OR { get; set; }

        public decimal ApnRate_Addon { get; set; }

        public double BookFee_Term_Multiplier { get; set; }

        public bool AdminLocked { get; set; }

        [StringLength(2)]
        public string Delivery_Method { get; set; }

        [StringLength(2)]
        public string Document_Delivery { get; set; }

        [StringLength(100)]
        public string Delivery_Email { get; set; }

        public int Max_Int_Free { get; set; }

        [Column(TypeName = "money")]
        public decimal? Monthly_Service_Fee { get; set; }

        public double? Customer_Rate_BL { get; set; }

        public int? Cmr_Book_Fee_Rate_BL { get; set; }

        public int? Score_Min_BL { get; set; }

        public int? Max_Term_BL { get; set; }

        public int? Max_Int_Free_BL { get; set; }

        public double? Deposit_Percent_BL { get; set; }

        public double? Dealer_Base_Rate_BL { get; set; }

        [StringLength(50)]
        public string Dlr_Book_Fee_Code_BL { get; set; }

        public int? Amount_Max_BL { get; set; }

        public int? Max_Def_Term_BL { get; set; }

        public bool? No_Override_BL { get; set; }

        public bool? Disable_BookFee_OR_BL { get; set; }

        public double Min_Customer_Rate { get; set; }

        public double Min_Customer_Rate_BL { get; set; }

        public bool Hide_Cash_Price { get; set; }

        public DateTime? MSF_EffectiveDate { get; set; }

        public bool Invoice_Number_Required { get; set; }

        public double Prime_Customer_Rate { get; set; }

        public double Govt_Customer_Rate { get; set; }

        [StringLength(10)]
        public string MSF_Previous_Rate { get; set; }

        [StringLength(100)]
        public string Sendback_Email { get; set; }

        [StringLength(25)]
        public string Reward_Scheme_Label { get; set; }

        public bool Reward_Scheme_Enabled { get; set; }

        public bool? Send_Stats_Email { get; set; }

        [StringLength(100)]
        public string Stats_Email_Address { get; set; }

        public double? Customer_Rate_VL { get; set; }

        public int? Cmr_Book_Fee_Rate_VL { get; set; }

        public int? Score_Min_VL { get; set; }

        public int? Max_Term_VL { get; set; }

        public int? Max_Int_Free_VL { get; set; }

        public double? Deposit_Percent_VL { get; set; }

        public double? Dealer_Base_Rate_VL { get; set; }

        [StringLength(50)]
        public string Dlr_Book_Fee_Code_VL { get; set; }

        public int? Amount_Max_VL { get; set; }

        public int? Max_Def_Term_VL { get; set; }

        public bool? No_Override_VL { get; set; }

        public bool? Disable_BookFee_OR_VL { get; set; }

        public double? Min_Customer_Rate_VL { get; set; }

        [Column("Postal Suburb")]
        [StringLength(50)]
        public string Postal_Suburb { get; set; }

        [Column("Postal City")]
        [StringLength(50)]
        public string Postal_City { get; set; }

        [Column(TypeName = "money")]
        public decimal? Monthly_Service_Fee_BL { get; set; }

        [Column(TypeName = "money")]
        public decimal? Monthly_Service_Fee_VL { get; set; }

        public double? Commission_Rate_BL { get; set; }

        public double? Commission_Rate_VL { get; set; }

        public double? Max_Base_Int_Rate { get; set; }

        public double? Max_Base_Int_Rate_BL { get; set; }

        public double? Max_Base_Int_Rate_VL { get; set; }

        public double? Customer_Rate_PL { get; set; }

        public double? Min_Customer_Rate_PL { get; set; }

        public int? Cmr_Book_Fee_Rate_PL { get; set; }

        [Column(TypeName = "money")]
        public decimal? Monthly_Service_Fee_PL { get; set; }

        public int? Max_Term_PL { get; set; }

        public int? Max_Def_Term_PL { get; set; }

        public int? Max_Int_Free_PL { get; set; }

        public double? Max_Base_Int_Rate_PL { get; set; }

        public double? Dealer_Base_Rate_PL { get; set; }

        public double? Deposit_Percent_PL { get; set; }

        public int? Score_Min_PL { get; set; }

        public double? Commission_Rate_PL { get; set; }

        [StringLength(50)]
        public string Dlr_Book_Fee_Code_PL { get; set; }

        public int? Amount_Max_PL { get; set; }

        public bool? Img_Pchs_Vari_Signed { get; set; }

        public DateTime? Img_Pchs_Date { get; set; }

        [StringLength(2)]
        public string Pchs_Method { get; set; }

        [StringLength(50)]
        public string Store_Code { get; set; }

        public double? Customer_Rate_RCF { get; set; }

        public double? Min_Customer_Rate_RCF { get; set; }

        public int? Cmr_Book_Fee_Rate_RCF { get; set; }

        [Column(TypeName = "money")]
        public decimal? Monthly_Service_Fee_RCF { get; set; }

        public int? Max_Term_RCF { get; set; }

        public int? Max_Def_Term_RCF { get; set; }

        public int? Max_Int_Free_RCF { get; set; }

        public double? Max_Base_Int_Rate_RCF { get; set; }

        public double? Dealer_Base_Rate_RCF { get; set; }

        public double? Deposit_Percent_RCF { get; set; }

        public int? Score_Min_RCF { get; set; }

        public double? Commission_Rate_RCF { get; set; }

        [StringLength(50)]
        public string Dlr_Book_Fee_Code_RCF { get; set; }

        public int? Amount_Max_RCF { get; set; }

        public bool? No_Override_RCF { get; set; }

        public bool? Disable_BookFee_OR_RCF { get; set; }

        public bool? Allow_NZPOST_ID_Check { get; set; }

        public bool? Set_PPI_Default_No { get; set; }

        public bool SHOW_FNC_OPTIN { get; set; }
    }
}
