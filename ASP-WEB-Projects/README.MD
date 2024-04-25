# .NET NOTES



## Ways to transfer data from controller to view

In .Net, there is mainly 4 ways to transfer data from controller to view. These are as follows

1. ViewData
2. ViewBag
3. TempData
4. Strongly Typed views

.

## 1. ViewData
ViewData is a key and value pair syntax 

**Syntax**

`ViewData["key"] = value`

**Key** : it is a unique key for this controller to transfer data from controller to view.

**Value** :  it is an object

ie. If we want to send data (**name**) from controller to view, Then in action method of controller set data

**ie.** `ViewData["name"]= "Raushan Tiwari"`

### Inside view we can access this data as

`@var varname = ViewData["key"]`

`@var name = ViewData["name"]`

Or we can directly print it as
`@ViewData["key"]`

Some data may need to be casted in view

## 2. ViewBag
It is same as ViewData with a small change in syntax

`@ViewBag.Property = value`

**Ie.** `@ViewBag.name = "Raushan"`

We can access it as `@ViewBag.name`

