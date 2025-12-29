<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoyaltyStatement.aspx.cs" Inherits="YourNamespace.LoyaltyStatement" %>

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
        body {
            background-color: #b7c9b4 !important;
        }
        
        .header-green {
            background-color: #2d5f3f;
            color: white;
            padding: 20px 30px;
            border-radius: 0;
            margin: 0 20px 0 20px;
        }
        
        .loyalty-card {
            box-shadow: 0 0 20px rgba(0,0,0,0.1);
            border-radius: 0;
            overflow: hidden;
            background: white;
            margin: 2px 20px 0 20px;
            margin-top: 20px;
        }
        
        .tier-badge {
            background-color: transparent;
            color: #333;
            padding: 0;
            border-radius: 0;
            font-weight: normal;
            display: inline-block;
        }
        
        .points-table {
            background-color: white;
        }
        
        .points-header th {
            background-color: #2d5f3f !important;
            color: white !important;
            font-weight: normal;
            padding: 8px 15px;
        }
        
        .table-bordered td {
            padding: 8px 15px;
        }
        
        .sidebar-img {
            width: 100%;
            margin-bottom: 10px;
            border-radius: 0;
        }
        
        .useful-tips {
            background-color: white;
            padding: 25px;
            margin-top: 20px;
            position: relative;
        }
        
        .useful-tips h6 {
            color: #7a9d7a;
            font-weight: bold;
            margin-bottom: 20px;
            font-size: 1.1rem;
        }
        
        .edit-icon {
            position: absolute;
            top: 25px;
            right: 25px;
            color: #666;
            cursor: pointer;
            font-size: 1.2rem;
        }
        
        .edit-icon:hover {
            color: #2d5f3f;
        }
        
        .useful-tips ul {
            list-style: disc;
            padding-left: 20px;
        }
        
        .useful-tips li {
            color: #808080;
            margin-bottom: 12px;
            line-height: 1.6;
        }
        
        .useful-tips a {
            color: #5b9dd5;
            text-decoration: none;
        }
        
        .statement-period-header {
            background-color: #b7c9b4;
            padding: 10px 15px;
        }
        
        .statement-period-content {
            background-color: white;
            padding: 10px 15px;
            border: 1px solid #dee2e6;
            border-top: 0;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid p-0">
            <!-- Full Width Header -->
            <div class="header-green d-flex justify-content-between align-items-center">
                <h3 class="mb-0">Awards +Plus</h3>
                <small>Loyalty eStatement</small>
            </div>
            
            <div class="row g-0">
                <!-- Main Content -->
                <div class="col-lg-9">
                    <div class="loyalty-card">
                        <!-- Body -->
                        <div class="p-4">
                            <!-- Greeting -->
                            <h6 class="mb-3">Dear Mr. <asp:Label ID="lblMemberName" runat="server" Text="John Doe"></asp:Label>,</h6>
                            
                            <p style="color: #666; font-size: 0.95rem;">
                                Thank you for being a valued member of the <strong>Skyways Loyalty Program</strong>. 
                                Below is your loyalty points statement.
                            </p>

                            <!-- Statement Period -->
                            <div class="mb-4">
                                <div class="statement-period-header">
                                    <div class="row">
                                        <div class="col-md-8">
                                            <strong>Statement Period</strong>
                                        </div>
                                        <div class="col-md-4 text-md-end">
                                            <strong>Tier Status</strong>
                                        </div>
                                    </div>
                                </div>
                                <div class="statement-period-content">
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
                                <table class="table table-bordered mb-0">
                                    <thead class="points-header">
                                        <tr>
                                            <th>Description</th>
                                            <th class="text-end" style="width: 150px;">Points</th>
                                        </tr>
                                    </thead>
                                    <tbody class="points-table">
                                        <tr>
                                            <td style="color: #808080;">Opening Balance</td>
                                            <td class="text-end">
                                                <asp:Label ID="lblOpeningBalance" runat="server" Text="12,500"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="color: #808080;">Points Earned</td>
                                            <td class="text-end">
                                                <asp:Label ID="lblPointsEarned" runat="server" Text="3,200"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="color: #808080;">Points Redeemed</td>
                                            <td class="text-end">
                                                <asp:Label ID="lblPointsRedeemed" runat="server" Text="-1,000"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr style="color: #666;">
                                            <td><strong>Closing Balance</strong></td>
                                            <td class="text-end">
                                                <strong><asp:Label ID="lblClosingBalance" runat="server" Text="14,700"></asp:Label></strong>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                            
                            <!-- Useful Tips Section -->
                            <div class="useful-tips">
                                <i class="bi bi-pencil edit-icon" onclick="editUsefulTips()" title="Edit Useful Tips"></i>
                                <h6>Useful tips:</h6>
                                <ul id="usefulTipsList">
                                    <li>Log into your Awards +Plus account to redeem miles and book tickets.</li>
                                    <li>Remember to make retroactive credit requests within 5 months of the flight.</li>
                                    <li>Ensure your name matches your Passport/CNIC for automatic mile accrual.</li>
                                    <li>Double-check that your membership number is included in your reservation's PNR.</li>
                                    <li>Your miles are valid for three years. For example, miles earned in 2022 will expire on <span style="color: #5b9dd5;">December 31, 2025</span>.</li>
                                    <li>Please submit your redemption request before <span style="color: #5b9dd5;">December 15, 2025</span> to avoid losing expiring miles.</li>
                                    <li>For more information, visit our website <a href="#">www.piac.com.pk</a> or contact our 24-hour service center at <strong>+92-21-111-786-786</strong>.</li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
                
                <!-- Sidebar -->
                <div class="col-lg-3">
                    <div class="p-3">
                        <img src="Images/image1.png" alt="Image 1" class="sidebar-img" />
                        <img src="Images/image2.png" alt="Image 2" class="sidebar-img" />
                        <img src="Images/image3.png" alt="Image 3" class="sidebar-img" />
                    </div>
                </div>
            </div>
        </div>
    </form>
    
    <!-- Bootstrap JS -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>
    
    <script>
        let isEditing = false;

        function editUsefulTips() {
            const tipsList = document.getElementById('usefulTipsList');
            const editIcon = document.querySelector('.edit-icon');

            if (!isEditing) {
                // Enable editing mode
                const tips = tipsList.querySelectorAll('li');
                tips.forEach(tip => {
                    tip.contentEditable = true;
                    tip.style.border = '1px dashed #2d5f3f';
                    tip.style.padding = '5px';
                    tip.style.marginBottom = '5px';
                });

                editIcon.classList.remove('bi-pencil');
                editIcon.classList.add('bi-check-circle');
                editIcon.style.color = '#2d5f3f';
                editIcon.title = 'Save Changes';
                isEditing = true;
            } else {
                // Save changes and disable editing
                const tips = tipsList.querySelectorAll('li');
                tips.forEach(tip => {
                    tip.contentEditable = false;
                    tip.style.border = 'none';
                    tip.style.padding = '0';
                });

                editIcon.classList.remove('bi-check-circle');
                editIcon.classList.add('bi-pencil');
                editIcon.style.color = '#666';
                editIcon.title = 'Edit Useful Tips';
                isEditing = false;

                alert('Changes saved successfully!');

                // Here you can add code to save to database
                // Example: send data to server using AJAX
                saveToDatabase();
            }
        }

        function saveToDatabase() {
            // Get all tips text
            const tips = document.querySelectorAll('#usefulTipsList li');
            const tipsArray = [];

            tips.forEach(tip => {
                tipsArray.push(tip.innerHTML);
            });

            // Example AJAX call to save to server
            // Uncomment and modify according to your backend
            /*
            fetch('SaveUsefulTips.aspx', {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json',
                },
                body: JSON.stringify({ tips: tipsArray })
            })
            .then(response => response.json())
            .then(data => {
                console.log('Success:', data);
            });
            */
        }
    </script>
</body>
</html>
