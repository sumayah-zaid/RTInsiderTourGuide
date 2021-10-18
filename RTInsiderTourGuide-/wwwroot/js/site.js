// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $(".dayBtn").click(function () {

        if ($(this).find(".fas").hasClass("down")) {
            $(this).find(".fas").removeClass("down");
        } else {
            $(".dayBtn .fas").removeClass("down");
            $(this).find(".fas").addClass("down");
        }

    });


    $("#days").change((e) => {
        let numOfDays = $(e.target).val();
        $("#activity").html("");
        for (let i = 0; i < numOfDays; i++) {
            let code = `<div>
                            <h3>Day ${i+1}</h3>
                            <div class="row">
                                <div class="col-6" >
                                    <div class="form-input">
                                        <label>Activity</label>
                                        <input name="TourActivities[${i}].TourActivity" class="form-control" />
                                    </div>
                                </div>
                                <div class="col-6" >
                                    <div class="form-input">
                                    <label>Describe Activity</label>
                                    <textarea class="form-control" rows="6" name="TourActivities[${i}].TourActivityDescription" ></textarea>
                                </div>
                            </div>
                        </div>`;
            $("#activity").append(code);
        }
        
    });
});