<template>
  <div class="nav-menu-container">
    <nav id="main-nav">
      <!-- <img src="img/logo.png" alt="Talent Exchange" id="logo" /> -->
      <router-link to="/">
        <span class="nav-title">Talent Exchange</span>
      </router-link>
      <SearchBar />
      <div class="auth">
        <ul>
          <li>
            <router-link to="/register">Register</router-link>
          </li>
          <li>
            <router-link to="/login">Login</router-link>
          </li>
        </ul>
      </div>
    </nav>
  </div>
</template>

<script lang="ts">
import { Component, Vue } from "vue-property-decorator";
import SearchBar from "../components/SearchBar.vue";

@Component({
  name: "NavMenu",
  components: {
    SearchBar
  }
})
export default class NavMenu extends Vue {}
</script>

<style scoped lang="scss">
@import "@/scss/global.scss";

#main-nav {
  display: flex;
  justify-content: space-between;
  align-items: center;
  padding-top: 1rem;
  background-color: #fff;
  box-shadow: 0px 0.5px 5px #ccc;
  padding: 0 20px;

  ul {
    display: flex;
  }
  li {
    padding: 1rem 1.5rem;
  }
  a {
    text-decoration: none;
    text-transform: uppercase;
    border-bottom: 0.2rem;
    padding-bottom: 0.2rem;
  }
}
</style>
