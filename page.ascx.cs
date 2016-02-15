using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    private string url;

    public string URL
    {
        get { return url; }
        set
        {
            url = value;
            lnkUrl.Text = value;
        }
    }

    private string cmt;
    public string COMMENTAIRE
    {
        get { return cmt; }
        set
        {
            cmt = value;
            lbCmt.Text = value;
        }
    }

    private string idp;
    public string IDP
    {
        get { return idp; }
        set { idp = value; }
    }




    protected void lnkUrl_Click(object sender, EventArgs e)
    {
        Response.Redirect(this.URL);
    }
}
