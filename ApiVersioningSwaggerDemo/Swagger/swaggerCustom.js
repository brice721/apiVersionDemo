+function replaceLogoTitle() {
    var logo = document.getElementById('logo');
    var last = logo.lastChild;
    var replacer = document.createElement('span');

    replacer.className = 'logo__title';
    replacer.innerText = 'Spire';
    last.replaceWith(replacer);

    var _body = document.body.children;
    var last2 = _body[_body.length - 1];

    var el = document.createElement('div');
    el.style = 'height: 60px';

    var footerClass = document.createElement('footer');
    footerClass.className = 'footer_class';
    footerClass.style = 'margin-top: 15px';

    last2.append(el);
    last2.append(footerClass);
}();