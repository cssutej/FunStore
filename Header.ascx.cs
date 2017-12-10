namespace funstore
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;

	/// <summary>
	///		Summary description for Header.
	/// </summary>
	public class Header : System.Web.UI.UserControl
	{
		protected System.Web.UI.WebControls.Button btnAbout;
		protected System.Web.UI.WebControls.Button btnHome;
		protected System.Web.UI.WebControls.Button btnRegister;
		protected System.Web.UI.WebControls.Button btnCart;
		protected System.Web.UI.WebControls.Button btnSearch;
		protected System.Web.UI.WebControls.Button btnLogin;
		protected System.Web.UI.WebControls.Image Image1;

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
		///		Required method for Designer support - do not modify
		///		the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
			this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
			this.btnHome.Click += new System.EventHandler(this.Button2_Click);
			this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Button2_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("default.aspx");

		}

		private void btnRegister_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("register.aspx");

		}

		private void btnCart_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("shoppingcart.aspx");

		}

		private void btnAbout_Click(object sender, System.EventArgs e)
		{
			
		}

		private void btnSearch_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("search.aspx");

		}

		private void btnLogin_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("login.aspx");

		}

		
		
	}
}
