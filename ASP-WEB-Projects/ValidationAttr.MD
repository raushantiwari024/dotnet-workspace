# Validation attribute in .NET Core

1. [Required(ErrorMessage="")]
2. [StringLength(max_len, MinimumLength= ,ErrorMessage="")]
1. [EmailAddress(ErrorMessage="")]
4. [Range(min,max,ErrorMessage="")]

> ## Note : Error message is optional 



# REGULAR EXPRESSION CODES

EMAIL REGULAR EXPRESSION CODE

^([0-9a-zA-Z] ([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$

^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$

Alpha-Numeric 
[a-zA-Z0-9]+

Strong password

(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$

CNIC
^[0-9]{5}-[0-9]{7}-[0-9]$

Pakistani Mobile No:
^((\+92)|(0092))-{0,1}\d{3}-{0,1}\d{7}$|^\d{11}$|^\d{4}-\d{7}$