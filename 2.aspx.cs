using System;
using System.Web.UI;

namespace YourNamespace
{
    public partial class LoyaltyStatement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadLoyaltyData();
            }
        }

        private void LoadLoyaltyData()
        {
            // Sample data - Replace with database calls
            lblMemberName.Text = "John Doe";
            lblStatementPeriod.Text = "01 Nov 2025 - 30 Nov 2025";
            lblTierStatus.Text = "Gold Member";

            // Points information
            lblOpeningBalance.Text = "12,500";
            lblPointsEarned.Text = "3,200";
            lblPointsRedeemed.Text = "-1,000";
            lblClosingBalance.Text = "14,700";

        }

        private void LoadFromDatabase(int memberId)
        {
          
        }
    }
}
