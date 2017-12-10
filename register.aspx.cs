using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Web.Security;



namespace funstore
{
	/// <summary>
	/// Summary description for register.
	/// </summary>
	public class register : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.Label Label2;
		protected System.Web.UI.WebControls.Label Label3;
		protected System.Web.UI.WebControls.Label Label5;
		protected System.Web.UI.WebControls.Label Label6;
		protected System.Web.UI.WebControls.Label Label7;
		protected System.Web.UI.WebControls.Label Label8;
		protected System.Web.UI.WebControls.Label Label9;
		protected System.Web.UI.WebControls.Label Label11;
		protected System.Web.UI.WebControls.Label Label12;
		protected System.Web.UI.WebControls.Label Label13;
		protected System.Web.UI.WebControls.TextBox txtfname;
		protected System.Web.UI.WebControls.TextBox txtaddress;
		protected System.Web.UI.WebControls.TextBox txtcity;
		protected System.Web.UI.WebControls.TextBox txtfax;
		protected System.Web.UI.WebControls.TextBox txtphone;
		protected System.Web.UI.WebControls.TextBox txtmail;
		protected System.Web.UI.WebControls.TextBox txtlname;
		protected System.Web.UI.WebControls.TextBox txtp1;
		protected System.Web.UI.WebControls.TextBox txtpass;
		protected System.Web.UI.WebControls.TextBox txtcardno;
		protected System.Web.UI.WebControls.Button btnRegister;
		protected System.Web.UI.WebControls.Label lblerror;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator1;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator2;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator3;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator6;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator7;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator8;
		protected System.Web.UI.WebControls.RegularExpressionValidator RegularExpressionValidator1;
		protected System.Web.UI.WebControls.TextBox txtcardt;
		protected System.Web.UI.WebControls.Button Button2;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Button2_Click(object sender, System.EventArgs e)
		{
			txtfname.Text="";
			txtlname.Text="";
			txtaddress.Text="";
			
			txtcity.Text="";
			txtphone.Text="";
		

			txtfax.Text="";
			txtmail.Text="";
			txtpass.Text="";
			txtp1.Text="";
			txtcardno.Text="";


		}

		private void btnRegister_Click(object sender, System.EventArgs e)
		{
			if (Page.IsValid == true) 
			{

				// Store off old temporary shopping cart ID
				funstore.cartDB shoppingCart = new funstore.cartDB();
				String tempCartId = shoppingCart.GetShoppingCartId();

//				// Add New Customer to CustomerDB database
			funstore.Customer accountSystem = new funstore.Customer();
			String  customerId = accountSystem.AddCustomer(txtfname.Text,txtlname.Text,txtaddress.Text ,txtcity.Text,txtphone.Text,txtmail.Text,txtpass.Text,txtcardt.Text,txtcardno.Text );

				


		if (customerId != "") 
			{

				// Set the user's authentication name to the customerId
				FormsAuthentication.SetAuthCookie(customerId, false);
               
					// Migrate any existing shopping cart items into the permanent shopping cart
				shoppingCart.MigrateCart(tempCartId, customerId);

					// Store the user's fullname in a cookie for personalization purposes
				Response.Cookies["funstore_FirstName"].Value = Server.HtmlEncode(txtfname.Text);

					// Redirect browser back to shopping cart page
				Response.Redirect("shoppingcart.aspx");
			}
			 else{
				
			lblerror.Text = customerId.ToString();				
		          }
			}



		}

	}
}
