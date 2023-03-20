const cartCounter = document.querySelector(".cart_counter");
const cartItems = document.querySelector(".cart_items");
const cartCloseBtn = document.querySelector('.fa-times');
const addToCartBtn = document.querySelectorAll('#m-cart-plus');
const totalCount = document.querySelector('#total_Counter');
const totalCost = document.querySelector('.total_cost');
const checkOutBtn = document.querySelector('.check_out_btn');

let paymentMethod = document.querySelectorAll("input[type=radio][name=payment_method]");
let selecyPaymentMethod = document.querySelector("input[type=radio][name=payment_method]:checked");
let phone = document.querySelector(".phone");
let paypal = 'Paypal';


let cartShpping = (JSON.parse(localStorage.getItem("cart_items")) || []);

//m\pament method API paypal
paymentMethod.forEach(pay => {
    pay.addEventListener("change", (e) => {
        if (pay.value === "evc") {
            phone.classList.toggle("active")
            paymentType = "Evc";
        } else {
            phone.classList.toggle("active")
            paymentType = "Paypal";
        }
    })

})

document.addEventListener("DOMContentLoaded", loadData);
// console.log(cartShpping)

checkOutBtn.addEventListener("click", () => {
    if (confirm("Mahubtaa In Aad Dirtay Dalabka"))
        // clearCartItem();
        if (paymentType = "Paypal") {
            checkOutPaypal();
        } else {
            // checkOutEvc();
        }
})
//add cart shopping list
cartCounter.addEventListener("click", () => {
    // cartItems.classList.add("active");
});
//close cart shopping list button
cartCloseBtn.addEventListener('click', function () {
    cartItems.classList.remove('active');
});

addToCartBtn.forEach(btn => {
    btn.addEventListener("click", () => {
        let parentElement = btn.parentElement;
        const product = {
            id: parentElement.querySelector("#product_id").value,
            name: parentElement.querySelector(".box h3").innerText,
            image: parentElement.querySelector(".image img").getAttribute("src"),
            price: parentElement.querySelector(".price").innerText.replace("$", ""),
            quantity: 1
        }
        let isInCart = cartShpping.filter(item => item.id === product.id).length > 0;
        // console.log(isInCart);
        cartShpping.push(product)

        if (!isInCart) {
            addItemToTheDOM(product)

        } else {
            alert("Horaa Udalbatay");
            return;
        }


        const cartDOMItems = document.querySelectorAll(".cart_item");
        //cartDOMItems.forEach( individualItem => {
        //    if( individualItem.querySelector("#product_id").value === product.id){
        //        increaseItem (individualItem,product);
        //        decreaseItem (individualItem,product);
        //        removeItem (individualItem,product);
        //    }
    });
    //cartShpping.push(product);
    calculateTotal();
    saveToLocalStorage();



});

});
function saveToLocalStorage() {
    localStorage.setItem("cart_items", JSON.stringify(cartShpping));

}
function addItemToTheDOM(product) {
    cartItems.insertAdjacentHTML("afterbegin",
        ` <div class="cart_item">
        <input type="hidden" name="" id="product_id" value="${product.id}">
        <img src="${product.image}" alt="" id="product_img">
        <h4 class="product_name">${product.name}</h4>
        <a action="decrease" class="btn_small">&minus;</a>
        <h4 class="product_quantity">${product.quantity}</h4>
        <a action="increase" class="btn_small">&plus;</a>
        <span class="product_price">${product.price}</span>
        <a  action="remove" class="btn_small btn_remove">&times;</a>
    </div>
    `)'}
    // calculat total items
    function calculateTotal() {
        //let total = 0;
        //cartShpping.forEach(item =>{
        //   total += item.quantity * item.price;
        //});
        //totalCost.innerText = total;
        //totalCount.innerText = cartShpping.length;
    }
    //increase button  of quatity

    function increaseItem(individualItem, product) {
        individualItem.querySelector("[action='increase']").addEventListener("click", () => {
            cartShpping.forEach(item => {
                if (item.id === product.id) {
                    individualItem.querySelector(".product_quantity").innerText = ++item.quantity;
                    calculateTotal();
                    saveToLocalStorage();
                }
            })
        })

    }

    function decreaseItem(individualItem, product) {
        individualItem.querySelector("[action='decrease']").addEventListener("click", () => {
            cartShpping.forEach(item => {
                if (item.id === product.id) {
                    if (item.quantity > 1) {
                        individualItem.querySelector(".product_quantity").innerText = --item.quantity;
                        calculateTotal();
                    } else {
                        cartShpping = cartShpping.filter(newElements => newElements.id !== product.id);
                        individualItem.remove();
                    }
                    calculateTotal();
                    saveToLocalStorage();
                }
            })
        })

    }
    function removeItem(individualItem, product) {
        individualItem.querySelector("[action='remove']").addEventListener("click", () => {
            cartShpping.forEach(item => {
                if (item.id === product.id) {
                    cartShpping = cartShpping.filter(newElements => newElements.id !== product.id);
                    individualItem.remove();
                    calculateTotal();
                    saveToLocalStorage();
                }
            })
        })

    }

    function loadData() {
        if (cartShpping.length > 0) {
            cartShpping.forEach(product => {
                addItemToTheDOM(product);

                const cartDOMItems = document.querySelectorAll(".cart_item");
                cartDOMItems.forEach(individualItem => {
                    if (individualItem.querySelector("#product_id").value === product.id) {
                        increaseItem(individualItem, product);
                        decreaseItem(individualItem, product);
                        removeItem(individualItem, product);
                    }
                });

                calculateTotal();
                saveToLocalStorage();
            })
        }

    }

    function clearCartItem() {
        localStorage.clear();
        cartShpping = [];
        document.querySelectorAll(".cart_items").forEach(item => {
            item.querySelectorAll(".cart_item").forEach(node => {
                node.remove();
            });
        });
        calculateTotal();
    }
    function checkOutPaypal() {
        let checkOutForm = `
    
    <form id="paypal_form" action="https://www.paypal.com/cgi-bin.websrc" method="post">
    <input type="hidden" name="cmd" value="_cart">
    <input type="hidden" name="upload" value="1">
    <input type="hidden" name="business" value="hibo6912@gmail.com">
    `;
        cartShpping.forEach((item, index) => {
            index++;
            checkOutForm += `
        <input type="hidden" name="item_name_${index}" value="${item.name}">
        <input type="hidden" name="amount_${index}" value="${item.price}">
        <input type="hidden" name="quantity_${index}" value="${item.quantity}">
        `;
        });
        checkOutForm += `
    <input type="submit"  value="payPal">
    </form>

    `;
        document.querySelector("body").insertAdjacentHTML("afterend", checkOutForm);
        document.querySelector("#paypal_form").submit();
    }