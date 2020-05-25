import Vue from 'vue'
import App from './App.vue'

Vue.config.productionTip = false

// new Vue({
//   render: h => h(App),
// }).$mount('#app')


var data = document.querySelectorAll('[data-type]');

Array.prototype.forEach.call(data, function(element) {
  console.log(element.dataset.type)
  console.log(element.id)
  //const componentData = JSON.parse(element.dataset.json)
  new Vue({
    render: h => h(App, {
      props: {
        type: element.dataset.type,
        id: element.id,
        //data: componentData
      }
    }),
  }).$mount(element)
});