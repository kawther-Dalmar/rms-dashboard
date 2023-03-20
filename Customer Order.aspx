﻿<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Customer Order.aspx.vb" Inherits="Customer_Order" %>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/css/bootstrap.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/css/all.min.css" />
    <link rel="stylesheet" href="styles.css" />
    <title>restaurant MS</title>
</head>

<body>
    <div class="d-flex" id="wrapper">
        <!-- Sidebar -->
        <div class="bg-white" id="sidebar-wrapper">
            <div class="sidebar-heading text-center py-4 primary-text fs-4 fw-bold text-uppercase border-bottom"><i class='fas fa-pizza-slice'></i>Rastaurant</div>
            <div class="list-group list-group-flush my-3">
                <a href="Dashboard.aspx" class="list-group-item list-group-item-action bg-transparent second-text active"><i
                        class="fas fa-tachometer-alt me-2"></i>Dashboard</a>
                <a href="users.aspx" class="list-group-item list-group-item-action bg-transparent second-text fw-bold"><i class='fas fa-user-alt'></i>User</a>
                <a href="Customer.aspx" class="list-group-item list-group-item-action bg-transparent second-text fw-bold">
                        <i class='fas fa-user-alt'></i>Customer</a>
                <a href="#" class="list-group-item list-group-item-action bg-transparent second-text fw-bold"><i
                        class="fas fa-paperclip me-2"></i>customer Order</a>
                <a href="Store Food.aspx" class="list-group-item list-group-item-action bg-transparent second-text fw-bold"><i
                        class="fas fa-shopping-cart me-2"></i>Store food</a>
                <a href="#" class="list-group-item list-group-item-action bg-transparent second-text fw-bold"><i
                        class="fas fa-charging-station"></i>Change Status</a>
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
                    <h2 class="fs-2 m-0">Dashboard</h2>
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
                 <%--  ========================Customer Order========================--%>

         
          
        <div class="container">
    

    <form class="mt32" action="#" runat="server">
          <h1 class="mt32 mb32">Customer <span>Order</span> Food</h1>
         <div class="form-group row">
             <asp:Label for="fname" ID="lblMessage" runat="server" Text=""  visibile="false"></asp:Label>

        </div>

                
        
        
        <div class="form-group row">
                   <div class="col-sm-10">
             <asp:DropDownList ID="ddlcusomerfname" runat="server" class="form-control" AutoPostBack="True">
             

              </asp:DropDownList>
            
            </div>
        </div>

       

         

        <div class="form-group row">
            <div class="col-sm-10">
           <asp:Button ID="btnAction" type="submit" runat="server" class="btn btn-info btn-block" Text="Order" />
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
