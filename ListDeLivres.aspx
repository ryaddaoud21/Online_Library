<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListDeLivres.aspx.cs" Inherits="BiB.ListDeLivres" %>
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Un Peu+</title>
    <link href="Style/layout.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.1/css/all.min.css" integrity="sha512-+4zCK9k+qNFUR5X+cKL9EIR+ZOhtIloNl9GIKS57V1MyNsYpYcUrUeQc9vNfzsWfV28IaLL3i96P9sdNyeRssA==" crossorigin="anonymous" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
</head>

<body>

    <!--Navbar-->

    <nav class="navbar">
        <div class="navbar__container">
            <a href="#home" id="navbar__logo">UN PEU PLUS +</a>
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
    <div class="menu" id="menu">
        <div class="main__img--cards"></div>

        <h1> Catégories</h1>
        <div class="menu__wrapper">
            <div class="category__card">
                <h2>INFORMATIQUE</h2>
                <div class="menu__btn"><a href="ListDeLivres.aspx?id=0" ><button>voire plus</button></a></div>
            </div>
            <div class="category__card">
                <h2>AFFAIRES</h2>
                <div class="menu__btn"><a href="ListDeLivres.aspx?id=1" ><button>voire plus</button></a></div>
            </div>
            <div class="category__card">
                <h2> TECHNOLOGIE</h2>
                <div class="menu__btn"><a href="ListDeLivres.aspx?id=2" ><button>voire plus</button></a></div>
            </div>

        </div>
    </div>

    <!--Menu section-->


    <div class="menu" id="menu">
        <h1>Les nouveautés livre à venir</h1>
     <asp:Label ID="Label1" class="menu__wrapper" runat="server" value="" >Inscription</asp:Label>

    </div>


    <div class="footer__container">


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