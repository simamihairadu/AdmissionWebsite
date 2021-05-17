// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var i = 1;
function addOption() {
    var div = $("<div />");
    var value = "";

    var specializationIdLabel = $("<label />").attr("asp-for", "Options[0].SpecializationId").attr("class", "control-label");
    var specializationIdInput = $("<input />").attr("asp-for", "Options[" + i + "].SpecializationId").attr("class", "form-control");

    div.append('<div class="form-group"> <label asp-for="Options[0].SpecializationId" class="control-label" ></label ><input asp-for="Options[0].SpecializationId" class="form-control" /><span asp-validation-for="Options[0].SpecializationId" class="text-danger"></span></div >');
    //div.append(specializationIdInput);

    $("#OptionContainer").append(div);
    i++;
        //<div class="form-group">
        //    <label asp-for="Options[0].SpecializationId" class="control-label"></label>
        //    <input asp-for="Options[0].SpecializationId" class="form-control" />
        //    <span asp-validation-for="Options[0].SpecializationId" class="text-danger"></span>
        //</div>
}