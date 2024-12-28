Object.defineProperty(window.navigator, 'standalone', { value: true });

let touchIdentifier = null; // شناسایی لمس

document.addEventListener('mousedown', function (e) {
    touchIdentifier = Date.now();
    const touchEvent = new TouchEvent('touchstart', {
        bubbles: true,
        cancelable: true,
        touches: [new Touch({
            identifier: touchIdentifier,
            target: e.target,
            clientX: e.clientX,
            clientY: e.clientY
        })]
    });
    e.target.dispatchEvent(touchEvent);
});

document.addEventListener('mousemove', function (e) {
    if (touchIdentifier !== null) {
        const touchMoveEvent = new TouchEvent('touchmove', {
            bubbles: true,
            cancelable: true,
            touches: [new Touch({
                identifier: touchIdentifier,
                target: e.target,
                clientX: e.clientX,
                clientY: e.clientY
            })]
        });
        e.target.dispatchEvent(touchMoveEvent);
    }
});

document.addEventListener('mouseup', function (e) {
    if (touchIdentifier !== null) {
        const touchEndEvent = new TouchEvent('touchend', {
            bubbles: true,
            cancelable: true,
            touches: []
        });
        e.target.dispatchEvent(touchEndEvent);
        touchIdentifier = null;
    }
});
