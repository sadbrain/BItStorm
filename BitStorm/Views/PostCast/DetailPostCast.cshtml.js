var video = document.getElementById('video');
var playButton = document.querySelector('.play-button');
var pauseIcon = document.querySelector('.pause-icon');
var timeoutId;
console.log("11111111111111111111111")
playButton.addEventListener('click', function () {
    if (video.paused) {
        video.play();
        playButton.style.display = 'none';
        pauseIcon.style.display = 'inline-block';
        playButton.style.outline = 'none';

        clearTimeout(timeoutId);
        timeoutId = setTimeout(function () {
            pauseIcon.style.display = 'none';
        }, 2000);
    } else {
        video.pause();
    }
});

pauseIcon.addEventListener('click', function () {
    video.pause();
});

video.addEventListener('pause', function () {
    playButton.style.display = 'inline-block';
    pauseIcon.style.display = 'none';
});