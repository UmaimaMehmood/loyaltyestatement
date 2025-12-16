<<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoyaltyStatement.aspx.cs" Inherits="YourNamespace.LoyaltyStatement" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Awards Plus - Loyalty Statement</title>
    
    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.10.0/font/bootstrap-icons.css" />
    
    <style>
       .header-green {
    background-color: #2d5f3f;
    color: white;
    padding: 12px 20px;   /* reduced height */
    border-radius: 8px 8px 0 0;
}

        
        .loyalty-card {
            box-shadow: 0 0 20px rgba(0,0,0,0.1);
            border-radius: 8px;
            overflow: hidden;
            background: white;
        }
        
       .tier-badge {
    background-color: transparent;
    color: #333;
    padding: 5px 15px;
    border-radius: 20px;
    font-weight: bold;
    display: inline-block;
}
        
        .points-table {
            background-color: #f8f9fa;
        }
        
        .points-header th {
    background-color: #2d5f3f !important;
    color: white !important;
}

        
        .flight-icon {
            color: #6c757d;
            font-size: 1.2rem;
        }
        
        .sidebar-img {
            width: 100%;
            margin-bottom: 10px;
            border-radius: 4px;
        }
    </style>
</head>
<body class="bg-light">
    <form id="form1" runat="server">
        <div class="container-fluid py-4">
            <div class="row">
                <!-- Main Content -->
                <div class="col-lg-9">
                    <div class="loyalty-card">
                        <!-- Header -->
                        <div class="header-green d-flex justify-content-between align-items-center">
                            <h2 class="mb-0">Awards +Plus</h2>
                            <small>Loyalty eStatement</small>
                        </div>
                        
                        <!-- Body -->
                        <div class="p-4">
                            <!-- Greeting -->
                            <h5 class="mb-3">Dear Mr. <asp:Label ID="lblMemberName" runat="server" Text="John Doe"></asp:Label>,</h5>
                            
                            <p class="text-muted">
                                Thank you for being a valued member of the <strong>Skyways Loyalty Program</strong>. 
                                Below is your loyalty points statement.
                            </p>

                            <!-- Statement Period -->
<div class="mb-4">
    <div style="background-color: #b7c9b4; padding: 10px; border-radius: 5px 5px 0 0;">
        <div class="row">
            <div class="col-md-8">
                <h6 class="fw-bold mb-0">Statement Period</h6>
            </div>
            <div class="col-md-4 text-md-end">
                <h6 class="fw-bold mb-0">Tier Status</h6>
            </div>
        </div>
    </div>
    <div style="background-color: white; padding: 10px; border: 1px solid #dee2e6; border-top: 2px solid #2d5f3f; border-radius: 0 0 5px 5px;">
        <div class="row align-items-center">
            <div class="col-md-8">
                <asp:Label ID="lblStatementPeriod" runat="server" Text="01 Nov 2025 - 30 Nov 2025"></asp:Label>
            </div>
            <div class="col-md-4 text-md-end">
                <span class="tier-badge">
                    <asp:Label ID="lblTierStatus" runat="server" Text="Gold Member"></asp:Label>
                </span>
            </div>
        </div>
    </div>
</div>
         
                             <!-- Points Table -->
                            <div class="table-responsive">
                                <table class="table table-bordered">
                                    <thead class="points-header">
                                        <tr>
                                            <th>Description</th>
                                            <th class="text-end" style="width: 150px;">Points</th>
                                        </tr>
                                    </thead>
                                    <tbody class="points-table">
                                        <tr>
                                            <td>Opening Balance</td>
                                            <td class="text-end">
                                                <asp:Label ID="lblOpeningBalance" runat="server" Text="12,500"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>Points Earned</td>
                                            <td class="text-end text-success">
                                                <asp:Label ID="lblPointsEarned" runat="server" Text="3,200"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>Points Redeemed</td>
                                            <td class="text-end text-danger">
                                                <asp:Label ID="lblPointsRedeemed" runat="server" Text="-1,000"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr class="fw-bold">
                                            <td>Closing Balance</td>
                                            <td class="text-end">
                                                <asp:Label ID="lblClosingBalance" runat="server" Text="14,700"></asp:Label>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                            
                            <!-- Upcoming Flight -->
                            <div class="mt-4 p-3 bg-light rounded">
                                <h6 class="mb-3">
                                    <i class="bi bi-airplane flight-icon"></i> Your Upcoming Flight
                                </h6>
                                <div class="row">
                                    <div class="col-md-6">
                                        <p class="mb-1"><strong>Flight:</strong> <asp:Label ID="lblFlightNumber" runat="server" Text="SW-204"></asp:Label></p>
                                        <p class="mb-1"><strong>Route:</strong> <asp:Label ID="lblRoute" runat="server" Text="Karachi → Dubai"></asp:Label></p>
                                        <p class="mb-1"><strong>Date:</strong> <asp:Label ID="lblFlightDate" runat="server" Text="18 Dec 2025"></asp:Label></p>
                                        <p class="mb-1"><strong>Departure:</strong> <asp:Label ID="lblDepartureTime" runat="server" Text="22:30"></asp:Label></p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                
                <!-- Sidebar -->
                <div class="col-lg-3 mt-4 mt-lg-0">
                    <div class="card border-0 shadow-sm">
                        <div class="card-body">
                            <img src="https://via.placeholder.com/250x150/4CAF50/FFFFFF?text=Travel+Destinations" 
                                 alt="Destinations" class="sidebar-img" />
                            <img src="https://via.placeholder.com/250x150/2196F3/FFFFFF?text=Awards+Program" 
                                 alt="Awards" class="sidebar-img" />
                            <img src="https://via.placeholder.com/250x150/FF9800/FFFFFF?text=Member+Benefits" 
                                 alt="Benefits" class="sidebar-img" />
                            <img src="https://via.placeholder.com/250x150/9C27B0/FFFFFF?text=Travel+With+Us" 
                                 alt="Travel" class="sidebar-img" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
    
    <!-- Bootstrap JS -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>
