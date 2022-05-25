
//membercreate ımageupload



(document.getElementById("inputTag")).addEventListener("change", () => {
    let inputImage = document.querySelector("input[type=file]").files[0];

    document.getElementById("imageName").innerText = inputImage.name;
})




