



/*//////////////////////////////////////////////////////////////////
[ FONT ]*/

@font-face {
  font-family: Poppins-Regular;
  src: url('../fonts/poppins/Poppins-Regular.ttf'); 
}

@font-face {
  font-family: Poppins-Medium;
  src: url('../fonts/poppins/Poppins-Medium.ttf'); 
}

@font-face {
  font-family: Poppins-Bold;
  src: url('../fonts/poppins/Poppins-Bold.ttf'); 
}

@font-face {
  font-family: Poppins-SemiBold;
  src: url('../fonts/poppins/Poppins-SemiBold.ttf'); 
}

/*//////////////////////////////////////////////////////////////////
[ RESTYLE TAG ]*/

* {
	margin: 0px; 
	padding: 0px; 
	box-sizing: border-box;
}

body, html {
	height: 100%;
	font-family: Poppins-Regular, sans-serif;
	background-color: black;
}

/*---------------------------------------------*/
a {
	font-family: Poppins-Regular;
	font-size: 14px;
	line-height: 1.7;
	color: #666666;
	margin: 0px;
	transition: all 0.4s;
	-webkit-transition: all 0.4s;
  -o-transition: all 0.4s;
  -moz-transition: all 0.4s;
}

a:focus {
	outline: none !important;
}

a:hover {
	text-decoration: none;
}

/*---------------------------------------------*/
h1,h2,h3,h4,h5,h6 {
	margin: 0px;
}

p {
	font-family: Poppins-Regular;
	font-size: 14px;
	line-height: 1.7;
	color: #666666;
	margin: 0px;
}

ul, li {
	margin: 0px;
	list-style-type: none;
}


/*---------------------------------------------*/
input {
	outline: none;
	border: none;
}

input[type="number"] {
    -moz-appearance: textfield;
    appearance: none;
    -webkit-appearance: none;
}

input[type="number"]::-webkit-outer-spin-button,
input[type="number"]::-webkit-inner-spin-button {
    -webkit-appearance: none;
}

textarea {
  outline: none;
  border: none;
}

textarea:focus, input:focus {
  border-color: transparent !important;
}

input:focus::-webkit-input-placeholder { color:transparent; }
input:focus:-moz-placeholder { color:transparent; }
input:focus::-moz-placeholder { color:transparent; }
input:focus:-ms-input-placeholder { color:transparent; }

textarea:focus::-webkit-input-placeholder { color:transparent; }
textarea:focus:-moz-placeholder { color:transparent; }
textarea:focus::-moz-placeholder { color:transparent; }
textarea:focus:-ms-input-placeholder { color:transparent; }

input::-webkit-input-placeholder {color: #cccccc;}
input:-moz-placeholder {color: #cccccc;}
input::-moz-placeholder {color: #cccccc;}
input:-ms-input-placeholder {color: #cccccc;}

textarea::-webkit-input-placeholder {color: #cccccc;}
textarea:-moz-placeholder {color: #cccccc;}
textarea::-moz-placeholder {color: #cccccc;}
textarea:-ms-input-placeholder {color: #cccccc;}

/*---------------------------------------------*/
button {
	outline: none !important;
	border: none;
	background: transparent;
}

button:hover {
	cursor: pointer;
}

iframe {
	border: none !important;
}


/*//////////////////////////////////////////////////////////////////
[ Utility ]*/
.txt1 {
  font-family: Poppins-Regular;
  font-size: 15px;
  color: #999999;
  line-height: 1.4;
}

.txt2 {
  font-family: Poppins-Regular;
  font-size: 15px;
  color: #666666;
  line-height: 1.4;
}

.txt3 {
  font-family: Poppins-Regular;
  font-size: 16px;
  color: #666666;
  line-height: 1.4;
}

.hov1:hover {
  color: #c87ef0;
}



/*//////////////////////////////////////////////////////////////////
[ login ]*/
.limiter {
  width: 100%;
  margin: 0 auto;
}

.container-login100 {
  width: 100%;  
  display: -webkit-box;
  display: -webkit-flex;
  display: -moz-box;
  display: -ms-flexbox;
  display: flex;
  flex-wrap: wrap;
  align-items: stretch;
  flex-wrap: wrap;
}


.wrap-login100 {
  width: 520px;
  min-height: 100vh;
  background: #fff;
  border-radius: 2px;
  position: relative;
}

/*------------------------------------------------------------------
[ Login100 more ]*/
.login100-more {
  background-repeat: no-repeat;
  background-position: center;
  background-size: cover;
  width: calc(100% - 520px);
  position: relative;
  z-index: 1;
}

.login100-more::before {
  content: "";
  display: block;
  position: absolute;
  z-index: -1;
  width: 100%;
  height: 100%;
  top: 0;
  left: 0;
  background: #e8519e;
  background: -webkit-linear-gradient(bottom, #e8519e, #c77ff2);
  background: -o-linear-gradient(bottom, #e8519e, #c77ff2);
  background: -moz-linear-gradient(bottom, #e8519e, #c77ff2);
  background: linear-gradient(bottom, #e8519e, #c77ff2);
  opacity: 0.8;
}

/*==================================================================
[ Form ]*/

.login100-form {
  width: 100%;
  display: -webkit-box;
  display: -webkit-flex;
  display: -moz-box;
  display: -ms-flexbox;
  display: flex;
  flex-wrap: wrap;
  justify-content: space-between;
}

.login100-form-title {
  display: block;
  width: 100%;
  font-family: Poppins-Bold;
  font-size: 39px;
  color: #333333;
  line-height: 1.2;
  text-align: left;
}



/*------------------------------------------------------------------
[ Input ]*/

.wrap-input100 {
  width: 100%;
  position: relative;
  border-bottom: 2px solid #dbdbdb;
  margin-bottom: 45px;
}

.label-input100 {
  font-family: Poppins-SemiBold;
  font-size: 18px;
  color: #999999;
  line-height: 1.2;
  padding-left: 2px;
}

.input100 {
  display: block;
  width: 100%;
  height: 50px;
  background: transparent;
  font-family: Poppins-Regular;
  font-size: 22px;
  color: #555555;
  line-height: 1.2;
  padding: 0 2px;
}

.focus-input100 {
  position: absolute;
  display: block;
  width: 100%;
  height: 100%;
  top: 0;
  left: 0;
  pointer-events: none;
}

.focus-input100::before {
  content: "";
  display: block;
  position: absolute;
  bottom: -2px;
  left: 0;
  width: 0;
  height: 2px;

  -webkit-transition: all 0.4s;
  -o-transition: all 0.4s;
  -moz-transition: all 0.4s;
  transition: all 0.4s;

  background: #d5007d;
  background: -webkit-linear-gradient(45deg, #d5007d, #e53935);
  background: -o-linear-gradient(45deg, #d5007d, #e53935);
  background: -moz-linear-gradient(45deg, #d5007d, #e53935);
  background: linear-gradient(45deg, #d5007d, #e53935);
}


.input100:focus + .focus-input100::before {
  width: 100%;
}

.has-val.input100 + .focus-input100::before {
  width: 100%;
}

/*==================================================================
[ Restyle Checkbox ]*/

.input-checkbox100 {
  display: none;
}

.label-checkbox100 {
  margin: 0;

  display: block;
  position: relative;
  padding-left: 26px;
  cursor: pointer;
}

.label-checkbox100::before {
  content: "\f00c";
  font-family: FontAwesome;
  font-size: 13px;
  color: transparent;

  display: -webkit-box;
  display: -webkit-flex;
  display: -moz-box;
  display: -ms-flexbox;
  display: flex;
  justify-content: center;
  align-items: center;
  position: absolute;
  width: 16px;
  height: 16px;
  border-radius: 2px;
  background: #e6e6e6;
  left: 0;
  top: 50%;
  -webkit-transform: translateY(-50%);
  -moz-transform: translateY(-50%);
  -ms-transform: translateY(-50%);
  -o-transform: translateY(-50%);
  transform: translateY(-50%);
}

.input-checkbox100:checked + .label-checkbox100::before {
  color: #c87ef0;
}

/*------------------------------------------------------------------
[ Button ]*/
.container-login100-form-btn {
  width: 100%;
  display: -webkit-box;
  display: -webkit-flex;
  display: -moz-box;
  display: -ms-flexbox;
  display: flex;
  flex-wrap: wrap;
  justify-content: space-between;
  align-items: center;
}

.wrap-login100-form-btn {
  display: block;
  position: relative;
  z-index: 1;
  border-radius: 25px;
  overflow: hidden;
}

.login100-form-bgbtn {
  position: absolute;
  z-index: -1;
  width: 100%;
  height: 300%;
  background: #e8519e;
  background: -webkit-linear-gradient(top, #e8519e, #c77ff2, #e8519e, #c77ff2);
  background: -o-linear-gradient(top, #e8519e, #c77ff2, #e8519e, #c77ff2);
  background: -moz-linear-gradient(top, #e8519e, #c77ff2, #e8519e, #c77ff2);
  background: linear-gradient(top, #e8519e, #c77ff2, #e8519e, #c77ff2);
  bottom: -100%;
  left: 0;

  -webkit-transition: all 0.4s;
  -o-transition: all 0.4s;
  -moz-transition: all 0.4s;
  transition: all 0.4s;
}

.login100-form-btn {
  display: -webkit-box;
  display: -webkit-flex;
  display: -moz-box;
  display: -ms-flexbox;
  display: flex;
  justify-content: center;
  align-items: center;
  padding: 0 20px;
  min-width: 244px;
  height: 50px;

  font-family: Poppins-Medium;
  font-size: 16px;
  color: #fff;
  line-height: 1.2;
}

.wrap-login100-form-btn:hover .login100-form-bgbtn {
  bottom: 0;
}


/*------------------------------------------------------------------
[ Alert validate ]*/

.validate-input {
  position: relative;
}

.alert-validate::before {
  content: attr(data-validate);
  position: absolute;
  max-width: 70%;
  background-color: #fff;
  border: 1px solid #c80000;
  border-radius: 2px;
  padding: 4px 30px 4px 10px;
  bottom: calc((100% - 25px) / 2);
  -webkit-transform: translateY(50%);
  -moz-transform: translateY(50%);
  -ms-transform: translateY(50%);
  -o-transform: translateY(50%);
  transform: translateY(50%);
  right: 2px;
  pointer-events: none;

  font-family: Poppins-Medium;
  color: #c80000;
  font-size: 14px;
  line-height: 1.4;
  text-align: left;

  visibility: hidden;
  opacity: 0;

  -webkit-transition: opacity 0.4s;
  -o-transition: opacity 0.4s;
  -moz-transition: opacity 0.4s;
  transition: opacity 0.4s;
}

.alert-validate::after {
  content: "\f06a";
  font-family: FontAwesome;
  display: block;
  position: absolute;
  color: #c80000;
  font-size: 18px;
  bottom: calc((100% - 25px) / 2);
  -webkit-transform: translateY(50%);
  -moz-transform: translateY(50%);
  -ms-transform: translateY(50%);
  -o-transform: translateY(50%);
  transform: translateY(50%);
  right: 8px;
}

.alert-validate:hover:before {
  visibility: visible;
  opacity: 1;
}

@media (max-width: 992px) {
  .alert-validate::before {
    visibility: visible;
    opacity: 1;
  }
}

.true-validate::after {
  content: "\f26b";
  font-family: Material-Design-Iconic-Font;
  font-size: 22px;
  color: #00ad5f;
  display: -webkit-box;
  display: -webkit-flex;
  display: -moz-box;
  display: -ms-flexbox;
  display: flex;
  align-items: center;
  justify-content: center;
  position: absolute;
  bottom: calc((100% - 25px) / 2);
  -webkit-transform: translateY(50%);
  -moz-transform: translateY(50%);
  -ms-transform: translateY(50%);
  -o-transform: translateY(50%);
  transform: translateY(50%);
  right: 5px;
}

/*//////////////////////////////////////////////////////////////////
[ Responsive ]*/

@media (max-width: 576px) {
  .wrap-login100 {
    padding-left: 15px;
    padding-right: 15px;
  }
}