window.initGalaxyCanvas = () => {

    var cursor = document.querySelector('.blob');
    let mouseX = window.innerWidth / 2;
    let mouseY = window.innerHeight / 2;

    document.addEventListener('mousemove', function (e) {
        //var x = e.clientX;
        //var y = e.clientY;
        //cursor.style.transform = `translate3d(calc(${e.clientX}px - 50%), calc(${e.clientY}px - 50%), 0)`
        mouseX = e.clientX;
        mouseY = e.clientY;
    });

    function animate() {
        cursor.style.left = `${mouseX}px`;
        cursor.style.top = `${mouseY}px`;
        requestAnimationFrame(animate);
    }

    animate();

}

window.initOceanCanvas = () => {

    var cursor = document.querySelector('.bub');
    let mouseX = window.innerWidth / 2;
    let mouseY = window.innerHeight / 2;

    document.addEventListener('mousemove', function (e) {
        //var x = e.clientX;
        //var y = e.clientY;
        //cursor.style.transform = `translate3d(calc(${e.clientX}px - 50%), calc(${e.clientY}px - 50%), 0)`
        mouseX = e.clientX;
        mouseY = e.clientY;
    });

    function animate() {
        cursor.style.left = `${mouseX}px`;
        cursor.style.top = `${mouseY}px`;
        requestAnimationFrame(animate);
    }

    animate();

}

window.culture = {
    get: () => localStorage.getItem('culture'),
    set: (value) => localStorage.setItem('culture', value)
};