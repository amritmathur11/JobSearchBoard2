// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

if ('clipboard' in navigator) {
    let canWriteClipboard = false;
    navigator.permissions.query({ name: 'clipboard-read' }).then((perms) => {
        canWriteClipboard = perms.state;

        if (canWriteClipboard === "granted") {
            $("#copyToClipboard").on('click', () => { navigator.clipboard.writeText(window.location.href); })
        } else if (canWriteClipboard === "prompt") {
            $("#copyToClipboard").on('click', () => { $("#clipboardPerms").show(); })
        } else {
            return;
        }
        $("#copyToClipboard").removeAttr('hidden');
    });



}

if ('caches' in window) {
    let offlineButton = $('#saveForOffline');

    if (offlineButton) {
        let isNotChached = false;

        offlineButton.on('click', async () => {
            let cache = await caches.open('offline-job-posts')
                .then(async (cache) => {
                    let isNotChached = await cache.match(window.location.href);

                    let cacheMech = () => {
                        cache.add(window.location.href);
                    }

                    if (isNotChached) {
                        offlineButton.val('💾');
                        offlineButton.attr('aria-label', 'Save for offline')
                        cacheMech = () => {
                            cache.delete(window.location.href);
                        }
                    } else {
                        offlineButton.val('💾⃠');
                        offlineButton.attr('aria-label', 'Remove from cache')
                    }

                    cacheMech();
                })
        });

        (async function () {
            await caches.open('offline-job-posts')
                .then(async (cache) => {
                    cache.match(window.location.href).then((isNotCached) => {

                        if (isNotChached) {
                            offlineButton.val('💾⃠');
                            offlineButton.attr('aria-label', 'Remove from cache')
                        } else {
                            offlineButton.val('💾');
                            offlineButton.attr('aria-label', 'Save for offline')
                        }
                    });
                })
        })();


    }

    offlineButton.removeAttr('hidden');
    //document.querySelector("#saveForOffline").removeAttribute('hidden');

}
/*
function ShareClick() {
    const shareModal = document.querySelector('.share');
    let sharePromise = navigator.share({
        name = "Share the Job",
        title = "Share API",
        urlfiuf = "https://localhost:44365/JobPosting"
    })
        .then((args) => console.table(args))
        .catch(error => console.log('Error sharing:', error));
}
*/


