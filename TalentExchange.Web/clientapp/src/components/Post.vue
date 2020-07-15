<template>
  <div class="container">
    <div class="card">
      <div class="card card-header">
        <div class="post-header">This is post header</div>
      </div>
      <div class="card card-content">
        Lorem ipsum dolor sit amet consectetur adipisicing elit. Labore itaque
        mollitia dicta in nulla accusamus cumque sit dolor quasi blanditiis,
        placeat praesentium ullam voluptatum qui quos autem commodi nam
        cupiditate!
      </div>
      <div class="card card-footer">footer</div>
    </div>
    <div class="card">
      <div class="card card-header">
        <div class="post-header">This is post header</div>
      </div>
      <div class="card card-content">
        Lorem ipsum dolor sit amet consectetur adipisicing elit. Labore itaque
        mollitia dicta in nulla accusamus cumque sit dolor quasi blanditiis,
        placeat praesentium ullam voluptatum qui quos autem commodi nam
        cupiditate!
      </div>
      <div class="card card-footer">footer</div>
    </div>
    <div class="card">
      <div class="card card-header">
        <div class="post-header">This is post header</div>
      </div>
      <div class="card card-content">
        Lorem ipsum dolor sit amet consectetur adipisicing elit. Labore itaque
        mollitia dicta in nulla accusamus cumque sit dolor quasi blanditiis,
        placeat praesentium ullam voluptatum qui quos autem commodi nam
        cupiditate!
      </div>
      <div class="card card-footer">footer</div>
    </div>
  </div>
</template>

<script lang="ts">
import Vue from "vue";
import Component from "vue-class-component";
import { Prop } from "vue-property-decorator";

export default class Post extends Vue {}
</script>

<style lang="scss" scoped>
.container {
  margin: 20px;
  .card {
    margin: 20px;
    max-width: 300px;
    max-height: 400px;
    background-color: red;
    border-radius: 4px;
  }
}
</style>
