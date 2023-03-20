<%@ Page Language="VB" AutoEventWireup="false" CodeFile="viewordered.aspx.vb" Inherits="viewordered" %>

<!DOCTYPE html>

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
    
       <%-- ==============View Orderd====================--%>

    <div class="container-fluid px-4">
                <div class="row g-3 my-2">
                    <div class="col-md-3">
                        <div class="p-3 bg-white shadow-sm d-flex justify-content-around align-items-center rounded">
                       <%--============ order============--%>
                            <div class="container">
    

    <form class="mt32" action="#" runat="server">
          <h1 class="mt32 mb32">Customer <span>Order</span> Food</h1>
         <div class="form-group row">
             <asp:Label for="fname" ID="lblMessage" runat="server" Text=""  visibile="false"></asp:Label>

        </div>

                
        
        
        <div class="form-group row">
                   
                        <div>
                            <asp:GridView ID="gvOrderView" runat="server" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" Width="100%">
                             <Columns>
                                <asp:CommandField  HeaderText="Add" SelectText="+" ShowSelectButton="True" ItemStyle-CssClass="item" >
                    <ItemStyle CssClass="item"></ItemStyle>
                                 </asp:CommandField>
                                    <asp:CommandField DeleteText="-" HeaderText="Sub" SelectText="-" ShowDeleteButton="True" ItemStyle-CssClass="item"  >
<ItemStyle CssClass="item"></ItemStyle>
                                 </asp:CommandField>
                        </Columns>
                                <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                                <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                                <RowStyle BackColor="White" ForeColor="#330099" />
                                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                                <SortedAscendingCellStyle BackColor="#FEFCEB" />
                                <SortedAscendingHeaderStyle BackColor="#AF0101" />
                                <SortedDescendingCellStyle BackColor="#F6F0C0" />
                                <SortedDescendingHeaderStyle BackColor="#7E0000" />
                    </asp:GridView>
                 </div>
            </div>
    </form>
   
</div>

                        </div>
                    </div>
                    </div>
        </div>
      
    
</body>
</html>
