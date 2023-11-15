var video = document.getElementById('video');
var welcomeMessageShown = false;

video.addEventListener('play', function () {
    if (!welcomeMessageShown) {
        alert('Welcome! Enjoy watching the video.');
        welcomeMessageShown = true;
    }
});

video.addEventListener('timeupdate', function () {
    var currentTime = video.currentTime;
    var duration = video.duration;

    if (currentTime >= 5 && currentTime <= duration) {
        alert('You have watched 3 minutes of the video. Great job!');
    } else if (currentTime > duration) {
        alert('Congratulations! You have finished watching the video.');
    }
});
