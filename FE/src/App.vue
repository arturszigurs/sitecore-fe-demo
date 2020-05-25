<template>
  <div id="app">
    <img alt="Vue logo" src="./assets/logo.png">
    <h1>{{type}}</h1>
    <h2>{{id}}</h2>
    <HelloWorld v-bind:msg="data.title"/>
  </div>
</template>

<script>
import HelloWorld from './components/HelloWorld.vue'

export default {
  name: 'App',
  props: ['type', 'id', 'data'],
  components: {
    HelloWorld
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
