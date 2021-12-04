<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Panier.aspx.cs" Inherits="BiB.Panier" %>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Un Peu+ |Panier</title>
    <link href="Style/layout.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.1/css/all.min.css" integrity="sha512-+4zCK9k+qNFUR5X+cKL9EIR+ZOhtIloNl9GIKS57V1MyNsYpYcUrUeQc9vNfzsWfV28IaLL3i96P9sdNyeRssA==" crossorigin="anonymous" />
    <link rel="stylesheet" href="style.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/css/bootstrap.min.css" rel="stylesheet">

</head>

<body>

    <!--Navbar-->

    <nav class="navbar">
        <div class="navbar__container">
            <a href="index.html" id="navbar__logo">UN PEU PLUS +</a>
            <div class="navbar__toggle" id="mobile-menu">
                <span class="bar"></span>
                <span class="bar"></span>
                <span class="bar"></span>
            </div>
             <ul class="navbar__menu">
                <li class="navbar__item">
                    <a href="WebForm4.aspx" class="navbar__links">Acceuil</a>
                </li>
                <li class="navbar__item">
                    <a href="#" class="navbar__links">Nouveautes</a>
                </li>
                <li class="navbar__item">
                    <a href="Panier.aspx" class="navbar__links "> Panier&nbsp;<i class="fa fa-shopping-cart"></i></a>
                </li>
                <li class="navbar__item">
                    <a href="SignIn.aspx" class="navbar__links">


                         <asp:Label ID="Insc" class="menu__wrapper" runat="server" value="" >Inscription</asp:Label>
                    </a>
                </li>
                <li class="navbar__btn">



                    <form runat="server">
          <asp:Button ID="Button" runat="server"   class="button" Text="Connexion" OnClick="Button1_Click" />

                        </form>
                        
                        
                        
                        <i class="fa fa-user"></i> </a>
                </li>
            </ul>
        </div>
    </nav>


    <!--Menu section-->


    <main id="cart" style="max-width:960px ; margin-top:-7pc;">
        <h1 id="panier_text">Votre Panier</h1>
        <hr>
        <div class="container-fluid">
            <div class="row align-items-start">
                <div class="col-12 col-sm-8 items">
                    <asp:Label ID="Label" class="col-12 col-sm-8 items" runat="server" ></asp:Label>

                
                    <hr>
                    <!--2-->
                </div>
                <div class="col-12 col-sm-4 p-3 proceed form">
                    <div class="row m-0">
                        <div class="col-sm-8 p-0">
                            <h6>Subtotal</h6>
                        </div>
                        <div class="col-sm-4 p-0">
                            <p id="subtotal"><asp:Label ID="Total" class="col-12 col-sm-8 items" runat="server" ></asp:Label></p>
                        </div>
                    </div>
                    <div class="row m-0">
                        <div class="col-sm-8 p-0 ">
                            <h6>Tax</h6>
                        </div>
                        <div class="col-sm-4 p-0">
                            <p id="tax">$0.00</p>
                        </div>
                    </div>
                    <hr>
                    <div class="row mx-0 mb-2">
                        <div class="col-sm-8 p-0 d-inline">
                            <h5>Total</h5>
                        </div>
                        <div class="col-sm-4 p-0">
                            <p id="total"> <asp:Label ID="TOTAL1" class="col-12 col-sm-8 items" runat="server" ></asp:Label></p>
                        </div>
                    </div>
                    <a href="#"><button id="btn-checkout" class="shopnow"><span>la caisse &nbsp;<i class="fa fa-checkout"></i></span></button></a>
                </div>
            </div>
        </div>
        </div>
    </main>
    <footer class="container">
    </footer>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/js/bootstrap.bundle.min.js"></script>
    <div class="footer__container">
        <div class="footer__links">
            <div class="footer__link--wrapper">
                <div class="footer__link--items">
                    <h2>Location</h2>
                    <p>Brooklyn</p>
                    <p>376 Fake Street</p>
                    <p>Brooklyn, NY — 11231</p>
                </div>
                <div class="footer__link--items">
                    <h2>Hours</h2>
                    <p>Monday — Thursday</p>
                    <p>8am — 11pm</p>
                    <p>Friday — Sunday</p>
                    <p>11am — 11pm</p>
                </div>
            </div>
            <div class="footer__link--wrapper">
                <div class="footer__link--items">
                    <h2>Food Truck</h2>
                    <p>25 Fake Street</p>
                    <p>New York, NY — 10003</p>
                    <p>(917) 555-1234</p>
                </div>
                <div class="footer__link--items">
                    <h2>Social media</h2>
                    <p>Instagram</p>
                    <p>Facebook</p>
                    <p>Twitter</p>
                </div>
            </div>
        </div>
        <section class="social__media">
            <div class="social__media--wrap">
                <div class="footer__logo">
                    <a href="/" id="footer__logo">Logo</a>
                </div>
                <p class="website__rights">&#169; UN PEU + 2021. All rights reserved</p>
                <div class="social__icons">
                    <a href="/" class="social__icon--link" target="_blank"><i class="fab fa-facebook"></i></a>
                    <a href="/" class="social__icon--link" target="_blank"><i class="fab fa-instagram"></i></a>
                    <a href="/" class="social__icon--link" target="_blank"><i class="fab fa-twitter"></i></a>
                </div>
            </div>
        </section>
    </div>
    <script src="app.js"></script>
</body>

</html>