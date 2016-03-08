(function (app) {
    app.AppComponent =
      ng.core.Component({
          selector: 'my-app',
          templateUrl: './Scripts/app/myApp.html'
      })
      .Class({
          constructor: function () { }
      });
})(window.app || (window.app = {}));