<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Food.aspx.vb" Inherits="Food" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Habsan Restuarent</title>
    <link rel="icon" href="./images/s-6.png">
    <!-- font awesome cdn link  -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/css/all.min.css">
    <!-- custom css file link  -->
    <link rel="stylesheet" href="style.css">
</head>
<body>   
    <form runat="server">
<!-- header section starts  -->
<header>
    <a href="#" class="logo"><i class="fas fa-utensils"></i><span>restaurant MS</span> </a>
    <div class="util">
        <i class="fa fa-home"><a href="Dashboard.aspx">Dashboard</a></i> 
    </div>
    <a href="viewordered.aspx">
      <div class="cart_counter">
        <i class="fa fa-cart-plus"></i>
          <asp:Label ID="lblCounter" runat="server" Text="0"></asp:Label>
         
      </div>
        </a>
</header>
       
  
  
<!-- header section ends -->
<!-- menu section starts  -->
<section class="menu" id="menu">
<h1 class="heading"> today's <span>speciality</span>  </h1>
 <div class="box-container">
   <div class="box">           
              <div class="content">
                <input type="hidden" name="" id="product_id" value="1">
                <div class="image">
                    <img src="images/pizza.png" alt="">
                </div>
                <div class="stars">
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star-half-alt"></i>
                </div>
                <h3><asp:Label ID="lblFoodName1" runat="server" Text="Hot Pizza"></asp:Label>Hot Pizza</h3>
                   <p>Lorem ipsum dolor sit, amet consectetur adipisicing elit. Excepturi, accusantium.</p>
                  <asp:Button ID="btnSave1" class="btn" runat="server" Text="Add to Cart" />
                  
                <span class="price">$12.99</span>
            </div>
        </div>
        <div class="box">
           
            <div class="content">
                <input type="hidden" name="" id="product_id" value="2">
                <div class="image">
                    <img src="images/burger.png" alt="">              
                </div>
                <div class="stars">
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star-half-alt"></i>
                </div>
                <h3> <asp:Label ID="lblFoodName2" runat="server" Text="Beef Burger"></asp:Label> Beef Burger</h3>
                <p>Lorem ipsum dolor sit, amet consectetur adipisicing elit. Excepturi, accusantium.</p>
                 <asp:Button ID="btnSave2" class="btn" runat="server" Text="Add to Cart" />

                <span class="price">$12.99</span>
            </div>
        </div>
        <div class="box">          
            <div class="content">
                <input type="hidden" name="" id="product_id" value="3">
                <div class="image">
                    <img src="images/canjera.jpg" alt="">                 
                </div>
                <div class="stars">
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star-half-alt"></i>
                </div>
                <h3>Somalia Style Canjera</h3>
                <p>Lorem ipsum dolor sit, amet consectetur adipisicing elit. Excepturi, accusantium.</p>
                <asp:Button ID="btnSave3" class="btn" runat="server" Text="Add to Cart" />
                  

                <span class="price">$12.99</span>
            </div>
        </div>

        <div class="box">
            
            <div class="content">
                <input type="hidden" name="" id="product_id" value="4">
                <div class="image">
                    <img src="./images/Spaghetti_Pasta.jpg" alt="">
                 
                </div>
                <div class="stars">
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star-half-alt"></i>
                </div>
                <h3>Pasta </h3>
                <p>Lorem ipsum dolor sit, amet consectetur adipisicing elit. Excepturi, accusantium.</p>

                 <asp:Button ID="btnSave4" class="btn" runat="server" Text="Add to Cart" />
                 
                <span class="price">$12.99</span>
            </div>
        </div>
        <div class="box">
           
            <div class="content">
                <input type="hidden" name="" id="product_id" value="5">
                <div class="image">
                    <img src="./images/desi pasta.jpg" alt="">                 
                </div>
                <div class="stars">
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star-half-alt"></i>
                </div>
                <h3>Desi Pasta</h3>
                <p>Lorem ipsum dolor sit, amet consectetur adipisicing elit. Excepturi, accusantium.</p>
                <asp:Button ID="btnSave5" class="btn" runat="server" Text="Add to Cart" />
                 
                <span class="price">$12.99</span>
            </div>
        </div>
        <div class="box">     
            <div class="content">
                <input type="hidden" name="" id="product_id" value="6">
                <div class="image">
                    <img src="./images/rice1.jpg" alt="">
                
                </div>
                <div class="stars">
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star-half-alt"></i>
                </div>
                <h3> Rice</h3>
                <p>Lorem ipsum dolor sit, amet consectetur adipisicing elit. Excepturi, accusantium.</p>
                <asp:Button ID="btnSave6" class="btn" runat="server" Text="Add to Cart" />
                 
>
                <span class="price">$12.99</span>
            </div>
        </div>
        <div class="box">     
            <div class="content">
                <input type="hidden" name="" id="product_id" value="7">
                <div class="image">
                    <img src="./images/Jollof_Rice.jpg" alt="">               
                </div>
                <div class="stars">
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star-half-alt"></i>
                </div>
                <h3>Jollof Rice</h3>
                <p>Lorem ipsum dolor sit, amet consectetur adipisicing elit. Excepturi, accusantium.</p>
                <asp:Button ID="btnSave7" class="btn" runat="server" Text="Add to Cart" />
                <span class="price">$12.99</span>
            </div>
        </div>
        <div class="box">          
           <div class="content">
            <input type="hidden" name="" id="product_id" value="8">
                <div class="image">
                    <img src="./images/Shawarma.jpg" alt="">               
                </div>
                <div class="stars">
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star-half-alt"></i>
                </div>
                <h3>Shawarmah</h3>
                <p>Lorem ipsum dolor sit, amet consectetur adipisicing elit. Excepturi, accusantium.</p>
                <asp:Button ID="btnSave8" class="btn" runat="server" Text="Add to Cart" />
                <span class="price">$12.99</span>
            </div>
        </div>
        <div class="box">         
            <div class="content">
                <input type="hidden" name="" id="product_id" value="9">
                <div class="image">
                    <img src="./images/malawah.jfif" alt="">                 
                </div>
                <div class="stars">
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star-half-alt"></i>
                </div>
                <h3>Malawah </h3>
                <p>Lorem ipsum dolor sit, amet consectetur adipisicing elit. Excepturi, accusantium.</p>
                 <asp:Button ID="btnSave9" class="btn" runat="server" Text="Add to Cart" />
                <span class="price">$12.99</span>
            </div>
        </div>
    </div>
</section>



 



















<!-- cart count  -->
    <!-- <div class="cartBox"> 
        <div class="cart">
            <i class="fa fa-times" aria-hidden="true"></i>
            <h1>cart</h1>
            <button class="checkOut">Check Out</button>
        </div>
      
    </div> -->

    <!-- <div class="payBox"> 
        <div class="pay">
            <i class="fa fa-times closePay" aria-hidden="true"></i>
            <h1>Lacag Bixin</h1>
            <button class="PayBtn">Hadda Dir</button>
        </div>
      
    </div> -->
<!-- menu section ends -->
<!-- custom js file link  -->
<script src="script.js"></script>

</form>
</body>
</html>
