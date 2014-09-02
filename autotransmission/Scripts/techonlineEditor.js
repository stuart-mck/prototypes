function toggleFirstChild(parent) {
    var target = $('#' + parent);
    if (target.length > 0) {
        target.children(".content, .editor").slideToggle('slow');
    }
}



function loadAttributePopup(id)
{
    $(id).modal();
}