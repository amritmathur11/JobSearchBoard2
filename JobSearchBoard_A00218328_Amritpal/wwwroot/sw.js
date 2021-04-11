function swInstall(event) {

    console.info('Service Worker Installing....');
}

self.addEventListener('install', swInstall);

//Cache First
self.addEventListener('fetch', function (event) {
    event.respondWith(
        caches.match(event.request).then(function (cacheResponse) {
            if (cacheResponse) {
                return cacheResponse;
            } else {
                return fetch(event.request).then((netResp) => netResp)
            }
           
        })
    )
})