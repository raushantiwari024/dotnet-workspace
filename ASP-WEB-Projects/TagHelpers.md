# Tag helpers in .NET core 8
> ## 1. Anchor tag helper

**Syntax** 
``` html
<a asp-controller="" asp-action="" asp-route-id="">Click Me!!!</a>
```
`asp-controller` Is use to specify controller name in url.

`asp-action` specifies the action name

`asp-route-id` it is a optional field that define id if any

> ## 2. Image Tag Helper

```html
<img src="" alt="" asp-append-version="true"/>
```
This `asp-append-version` make it server side code.

> ## 3. Form with tag helper

```html
<form asp-action="Index" asp-controller="Home" method="post">
    <input asp-for="Name" class="form-control" placeholder="Enter Your Name" />
    <input asp-for="Age" class="form-control" placeholder="Enter Your Age" />

    <select asp-for="Gender" class="form-control" asp-items="Html.GetEnumSelectList<Gender>()">
        <option value="">Select Gender</option>
    </select>

    <label>
        <b>Married Status</b>
    </label>
    <div class="d-flex align-items-strech">
        <div class="form-check">
            <input class="form-check-input" type="radio" asp-for="Married" value="Yes">
            <label class="form-check-label mr-3" for="flexRadioDefault1">
                Male
            </label>
        </div>
        <div class="form-check ml-3">
            <input class="form-check-input" type="radio" asp-for="Married" value="No">
            <label class="form-check-label" for="flexRadioDefault2">
                Female
            </label>
        </div>
        
    </div>
    <textarea asp-for="Description" class="form-control"></textarea>

    <input asp-for="Designation" class="form-control" placeholder="Enter Your Designation" />
    <input asp-fot="Salary" class="form-control" placeholder="Enter Your Salary" />
    <input type="submit" value="Submit" class="btn btn-primary form-control">
</form>
```

## Keywords in this form

`asp-for` Maps a model property with form input element

`asp-items` use to fill a drop-down list with a `enum` values, that's why `Html.GetEnumSelectList<Gender>()` is used.`Gender` is a `enum`.

