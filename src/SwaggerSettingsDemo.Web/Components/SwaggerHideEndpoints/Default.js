(function ($) {

    $(function () {

        $("input[name='HideEndpoints']").change(function() {
            console.log(this.value);
            $("#SwaggerHideEndpointsForm").submit();
        });
        
        $("#SwaggerHideEndpointsForm").submit(function(e) {
            e.preventDefault();
            
            var form = $(this).serializeFormToObject();
            var value = form.hideEndpoints;

            swaggerSettingsDemo.swaggerSetting.updateSetting("SwaggerHideEndpoint", value)
                .then(function() {
                    $(document).trigger("AbpSettingSaved");
                });
        });
    });

})(jQuery);