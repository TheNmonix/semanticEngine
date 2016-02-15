using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DSTableAdapters;

public partial class engine : System.Web.UI.UserControl
{
    string[] mots;
    List<string> MesIdPages;
    PageTableAdapter pages = new PageTableAdapter();

    protected void Page_Load(object sender, EventArgs e)
    {

    }



    private string crit;
    public string Critere
    {
        get { return crit; }
        set
        {
            crit = value;
            mots = crit.Trim().Split(' ');
            MesIdPages = new List<string>();
            foreach (string word in mots)
            {
                if (!word.Trim().Equals(""))
                {
                    foreach (DS.PageRow pg in pages.GetDataByTexte(word))
                    {
                        if (!MesIdPages.Contains("" + pg.idPage))
                        {
                            MesIdPages.Add("" + pg.idPage);
                            page p = (page)LoadControl("page.ascx");
                            p.IDP = "" + pg.idPage;
                            p.URL = pg.url;
                            p.COMMENTAIRE = pg.commentaire;
                            this.Controls.Add(p);
                        }

                    }

                }

            }

        }
    }
}
