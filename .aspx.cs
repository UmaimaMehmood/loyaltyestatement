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

            // Flight information
            lblFlightNumber.Text = "SW-204";
            lblRoute.Text = "Karachi → Dubai";
            lblFlightDate.Text = "18 Dec 2025";
            lblDepartureTime.Text = "22:30";
        }

        // Example method to load data from database
        private void LoadFromDatabase(int memberId)
        {
           
        }
    }
}
