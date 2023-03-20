<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Customer.aspx.vb" Inherits="Customer" %>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/css/bootstrap.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/css/all.min.css" />
    <link rel="stylesheet" href="styles.css" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"/>

     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"/>
    <title>User</title>
    <style>
        form{
            margin-left:5%;
        }
        h1{
            color: var(--second-text-color);
            text-align:center;
            font-weight:bolder;

        }
    </style>
</head>

<body>
    <div class="d-flex" id="wrapper">
        <!-- Sidebar -->
        <div class="bg-white" id="sidebar-wrapper">
            <div class="sidebar-heading text-center py-4 primary-text fs-4 fw-bold text-uppercase border-bottom">
                    <%--class="fas fa-user-secret me-2"></i>--%> <i class='fas fa-pizza-slice'></i>Rastaurant</div>
            <div class="list-group list-group-flush my-3">
                <a href="Dashboard.aspx" class="list-group-item list-group-item-action bg-transparent second-text active"><i
                        class="fas fa-tachometer-alt me-2"></i>Dashboard</a>
                <a href="users.aspx" class="list-group-item list-group-item-action bg-transparent second-text fw-bold"><i class='fas fa-user-alt'></i>User</a>
                <a href="Customer.aspx" class="list-group-item list-group-item-action bg-transparent second-text fw-bold">
                        <i class='fas fa-user-alt'></i>Customer</a>
                <a href="Customer Order.aspx" class="list-group-item list-group-item-action bg-transparent second-text fw-bold"><i
                        class="fas fa-paperclip me-2"></i>customer Order</a>
                <a href="Store Food.aspx" class="list-group-item list-group-item-action bg-transparent second-text fw-bold"><i
                        class="fas fa-shopping-cart me-2"></i>Store food</a>
                <a href="#" class="list-group-item list-group-item-action bg-transparent second-text fw-bold"><i
                        class="fas fa-charging-station"></i>change status</a>
                <a href="#" class="list-group-item list-group-item-action bg-transparent second-text fw-bold"><i
                        class="fas fa-comment-dots me-2"></i>Chat</a>
                <a href="#" class="list-group-item list-group-item-action bg-transparent second-text fw-bold"><i
                        class="fas fa-map-marker-alt me-2"></i>Outlet</a>
                <a href="#" class="list-group-item list-group-item-action bg-transparent text-danger fw-bold"><i
                        class="fas fa-power-off me-2"></i>Logout</a>
            </div>
        </div>
        <!-- /#sidebar-wrapper -->

        <!-- Page Content -->
        <div id="page-content-wrapper">
            <nav class="navbar navbar-expand-lg navbar-light bg-transparent py-4 px-4">
                <div class="d-flex align-items-center">
                    <i class="fas fa-align-left primary-text fs-4 me-3" id="menu-toggle"></i>
                    <h2 class="fs-2 m-0">RMS</h2>
                </div>

                <button class="navbar-toggler" type="button" data-bs-toggle="collapse"
                    data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent"
                    aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>

                <div class="collapse navbar-collapse" id="navbarSupportedContent">
                    <ul class="navbar-nav ms-auto mb-2 mb-lg-0">
                        <li class="nav-item dropdown">
                            <a class="nav-link dropdown-toggle second-text fw-bold" href="#" id="navbarDropdown"
                                role="button" data-bs-toggle="dropdown" aria-expanded="false">
                                
                                <!-- <i class="fas fa-user me-2"></i>John Doe -->
                            </a>
                            <%--<ul class="dropdown-menu" aria-labelledby="navbarDropdown">
                                <li><a class="dropdown-item" href="#">Profile</a></li>
                                <li><a class="dropdown-item" href="#">Settings</a></li>
                                <li><a class="dropdown-item" href="#">Logout</a></li>
                            </ul>--%>
                        </li>
                    </ul>
                </div>
            </nav>

            <div class="container-fluid px-4">
                

                
                    <%--=========users==================--%>
                <div class="container">
    

                <form class="mt32" action="#" runat="server">
        
                <div class="records table-responsive" >
                    <h1>customer Registration </h1>
                </div>
          
                 <div class="form-group row">
                     <asp:Label for="fname" ID="lblMessage" runat="server" Text=""  visibile="false"></asp:Label>

             </div>
       
                <div class="form-group row">
     
              <div class="col-sm-10">
                <asp:TextBox ID="txtfname" type="text" runat="server" class="form-control"   placeholder="Customer name"></asp:TextBox>
             
            </div>
            </div>
        
         <div class="form-group row">
       
            <div class="col-sm-10">
      <asp:TextBox ID="txtaddress" type="text" runat="server" class="form-control" placeholder="Your Address..."></asp:TextBox>

            </div>
        </div>  
                    <div class="form-group row">
       
                         <div class="col-sm-10">
                        <asp:TextBox ID="txtphone" type="number" runat="server" class="form-control" placeholder="Your Phone..."></asp:TextBox>

                        </div>
                    </div>
        <div class="form-group row">
                   <div class="col-sm-10">
             <asp:DropDownList ID="ddlG" runat="server" class="form-control">
             <asp:ListItem Selected="True">----Select type----</asp:ListItem>
             <asp:ListItem>Male</asp:ListItem>
             <asp:ListItem>Famel</asp:ListItem>

              </asp:DropDownList>
            
            </div>
        </div>

         <div class="form-group row">
         
            <div class="col-sm-10">
      <asp:TextBox ID="txtDor" type="date" runat="server" class="form-control" placeholder="Dor Date..."></asp:TextBox>

            </div>
        </div>

        
        <div class="form-group row">
            <div class="col-sm-10"">
           <asp:Button ID="btnAction" type="submit" runat="server" class="btn btn-success btn-block" Text="Save" />
            </div>
        </div>

         <div class="form-group row">
        <div class="col-md-10">
            
            <asp:GridView ID="dgvCustomer" Width="100%" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:CommandField SelectText="Edit" ShowSelectButton="True" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
        

                
        </div>
    </div>
    </form>
   
</div>
                

            </div>
        </div>
    </div>
    <!-- /#page-content-wrapper -->
    

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/js/bootstrap.bundle.min.js"></script>
    <script>
        var el = document.getElementById("wrapper");
        var toggleButton = document.getElementById("menu-toggle");

        toggleButton.onclick = function () {
            el.classList.toggle("toggled");
        };
    </script>
</body>

</html>
