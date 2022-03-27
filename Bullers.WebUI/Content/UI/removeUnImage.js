const images = document.querySelectorAll(".detail-img-mini");
const BigIm = document.getElementsByClassName("detail-img")[0];
var HasSrcIm;
images.forEach(function (image) {
    const src = image.getAttribute('src');

    if (!src) {
        //console.log("is empty");
        image.remove();

    }
    else {
        HasSrcIm = image.src;
    }
});

//const srcBig = BigIm.getAttribute('src');

//if (!srcBig || srcBig == null) {

//    srcBig.src = "/Contentd";
//    console.log(srcBig.src);
//}
