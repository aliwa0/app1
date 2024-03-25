
/* /m
   This file is generated from NFS ORM VS Extension v1.9.0
   Any change to this class can cause unexpected behavior. Therefore, it is higly recommended not to change the contents of this file.
*/

// ReSharper disable All
#pragma warning disable CS1591

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using NS.BaseModels;
using System.Collections.ObjectModel;



namespace CMS.Models.EarlyTermination
{

	///CONT_CMPT_PLAN_TAX
	public partial class  EtContractCmptRepaymentPlanTax //: BaseModel
	{
		
				private Int32 _cmpt_plan_tax_id;
				private Int32 _cont_cmpt_rpmt_plan_id;
				private Int32? _cont_id;
				private Int32? _aset_id;
				private Int32? _rntl_id;
				private Int32 _tax_type_id;
				private Decimal _tax_rate;
				private Decimal _itc_pct;
				private Decimal _tax_base_amnt;
				private Decimal _tax_amt;
				private Decimal _net_tax_amnt;
				private Decimal _tax_setl_amnt;
				private Decimal _tax_adjt_amnt;
				private Decimal _itc_amnt;
				private String _tax_conf_type_key;
				private Decimal? _cmpt_tax_rcbl_amnt;
				private String _amnt_cmpt_type_key;
				private String _insr_by;
				private String _updt_by;
				private DateTime _insr_dte;
				private DateTime _updt_dte;
		
		//public  EtContractCmptRepaymentPlanTax  EtContractCmptRepaymentPlanTax { get { return this; } } //Self reference property

		
		//public Int32 CMPT_PLAN_TAX_ID
		//{
		//	get { return _cmpt_plan_tax_id; }
		//	set
		//	{
		//		CheckSetProperty(ref _cmpt_plan_tax_id, value);
		//	}
		//}

		
		//public Int32 CONT_CMPT_RPMT_PLAN_ID
		//{
		//	get { return _cont_cmpt_rpmt_plan_id; }
		//	set
		//	{
		//		CheckSetProperty(ref _cont_cmpt_rpmt_plan_id, value);
		//	}
		//}

		
		//public Int32? CONT_ID
		//{
		//	get { return _cont_id; }
		//	set
		//	{
		//		CheckSetProperty(ref _cont_id, value);
		//	}
		//}

		
		//public Int32? ASET_ID
		//{
		//	get { return _aset_id; }
		//	set
		//	{
		//		CheckSetProperty(ref _aset_id, value);
		//	}
		//}

		
		//public Int32? RNTL_ID
		//{
		//	get { return _rntl_id; }
		//	set
		//	{
		//		CheckSetProperty(ref _rntl_id, value);
		//	}
		//}

		
		//public Int32 TAX_TYPE_ID
		//{
		//	get { return _tax_type_id; }
		//	set
		//	{
		//		CheckSetProperty(ref _tax_type_id, value);
		//	}
		//}

		
		//public Decimal TAX_RATE
		//{
		//	get { return _tax_rate; }
		//	set
		//	{
		//		CheckSetProperty(ref _tax_rate, value);
		//	}
		//}

		
		//public Decimal ITC_PCT
		//{
		//	get { return _itc_pct; }
		//	set
		//	{
		//		CheckSetProperty(ref _itc_pct, value);
		//	}
		//}

		
		//public Decimal TAX_BASE_AMNT
		//{
		//	get { return _tax_base_amnt; }
		//	set
		//	{
		//		CheckSetProperty(ref _tax_base_amnt, value);
		//	}
		//}

		
		//public Decimal TAX_AMT
		//{
		//	get { return _tax_amt; }
		//	set
		//	{
		//		CheckSetProperty(ref _tax_amt, value);
		//	}
		//}

		
		//public Decimal NET_TAX_AMNT
		//{
		//	get { return _net_tax_amnt; }
		//	set
		//	{
		//		CheckSetProperty(ref _net_tax_amnt, value);
		//	}
		//}

		
		//public Decimal TAX_SETL_AMNT
		//{
		//	get { return _tax_setl_amnt; }
		//	set
		//	{
		//		CheckSetProperty(ref _tax_setl_amnt, value);
		//	}
		//}

		
		//public Decimal TAX_ADJT_AMNT
		//{
		//	get { return _tax_adjt_amnt; }
		//	set
		//	{
		//		CheckSetProperty(ref _tax_adjt_amnt, value);
		//	}
		//}

		
		//public Decimal ITC_AMNT
		//{
		//	get { return _itc_amnt; }
		//	set
		//	{
		//		CheckSetProperty(ref _itc_amnt, value);
		//	}
		//}

		
		//public String TAX_CONF_TYPE_KEY
		//{
		//	get { return _tax_conf_type_key; }
		//	set
		//	{
		//		CheckSetProperty(ref _tax_conf_type_key, value);
		//	}
		//}

		
		//public Decimal? CMPT_TAX_RCBL_AMNT
		//{
		//	get { return _cmpt_tax_rcbl_amnt; }
		//	set
		//	{
		//		CheckSetProperty(ref _cmpt_tax_rcbl_amnt, value);
		//	}
		//}

		
		//public String AMNT_CMPT_TYPE_KEY
		//{
		//	get { return _amnt_cmpt_type_key; }
		//	set
		//	{
		//		CheckSetProperty(ref _amnt_cmpt_type_key, value);
		//	}
		//}

		
		//public String INSR_BY
		//{
		//	get { return _insr_by; }
		//	set
		//	{
		//		CheckSetProperty(ref _insr_by, value);
		//	}
		//}

		
		//public String UPDT_BY
		//{
		//	get { return _updt_by; }
		//	set
		//	{
		//		CheckSetProperty(ref _updt_by, value);
		//	}
		//}

		
		//public DateTime INSR_DTE
		//{
		//	get { return _insr_dte; }
		//	set
		//	{
		//		CheckSetProperty(ref _insr_dte, value);
		//	}
		//}

		
		//public DateTime UPDT_DTE
		//{
		//	get { return _updt_dte; }
		//	set
		//	{
		//		CheckSetProperty(ref _updt_dte, value);
		//	}
		//}

		

		
	}

		public class  EtContractCmptRepaymentPlanTaxValidator// : BaseValidation
	{

	
		//public override List<string> MandatoryFields { get; protected set; } 
		//	= new List<string>() { "CMPT_PLAN_TAX_ID", "CONT_CMPT_RPMT_PLAN_ID", "TAX_TYPE_ID", "TAX_RATE", "ITC_PCT", "TAX_BASE_AMNT", "TAX_AMT", "NET_TAX_AMNT", "TAX_SETL_AMNT", "TAX_ADJT_AMNT", "ITC_AMNT", "INSR_BY", "UPDT_BY", "INSR_DTE", "UPDT_DTE"  };

		//public override Dictionary<string, int> MaxLengthFields { get; protected set; } = new Dictionary<string, int>()
		//{
		//                 ["TAX_CONF_TYPE_KEY"] = 10
		//   , ["AMNT_CMPT_TYPE_KEY"] = 20
		//  , ["INSR_BY"] = 20
		//  , ["UPDT_BY"] = 20
		   
		//};

				public  EtContractCmptRepaymentPlanTaxValidator()
		{

		

			
			//ColumnTable = new ReadOnlyDictionary<string, string>(new Dictionary<string, string>()
   //     {
		 //           { "CMPT_PLAN_TAX_ID","CONT_CMPT_PLAN_TAX" },
			//            { "CONT_CMPT_RPMT_PLAN_ID","CONT_CMPT_PLAN_TAX" },
			//            { "CONT_ID","CONT_CMPT_PLAN_TAX" },
			//            { "ASET_ID","CONT_CMPT_PLAN_TAX" },
			//            { "RNTL_ID","CONT_CMPT_PLAN_TAX" },
			//}); 
		
			} //end ctor
	
	

	}//end validator class

#pragma warning restore CS1591

}//end namespace