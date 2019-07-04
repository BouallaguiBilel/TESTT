;#DropDB TESTEasyTest

#Application TEST.Win
#Application TEST.Web

*FillForm
 User Name = Admin
*Action Log In

#IfDef TEST.Win

*Action About...
 
*Action OK

#EndIf

#IfDef TEST.Web
*Action Navigation(My Details)
#EndIf
