<template>
  <div class="index container">
    <div class="card" v-for="post in posts" :key="post.id">
      <div>
        <h4 class="card-title">{{ post.title }}</h4>
      </div>
      <div class="card-location">{{ post.location }}</div>
      <div class="card-content">{{ post.content }}</div>
      <ul class="card-tags">
        <li v-for="(tag, index) in post.tags" :key="index">
          <span class="chip">{{ tag }}</span>
        </li>
      </ul>
    </div>
  </div>
</template>

<script lang="ts">
// import { Component, Vue } from "vue-property-decorator";
// // import Post from "@/components/Post.vue";
// import { IPostService } from "@/types/Post";

export default {
  name: "Index",
  components: {
    // Post
  },
  data() {
    return {
      posts: [
        {
          id: "1",
          title: "This is title for card",
          content: "this is content for card",
          location: "this is location",
          tags: ["tag1", "tag2", "tag3"]
        },
        {
          id: "2",
          title: "This is title for card",
          content: "this is content for card",
          location: "this is location",
          tags: ["tag1", "tag2", "tag3"]
        },
        {
          id: "3",
          title: "This is title for card",
          content: "this is content for card",
          location: "this is location",
          tags: ["tag1", "tag2", "tag3"]
        },
        {
          id: "3",
          title: "This is title for card",
          content: "this is content for card",
          location: "this is location",
          tags: ["tag1", "tag2", "tag3"]
        },
        {
          id: "3",
          title: "This is title for card",
          content: "this is content for card",
          location: "this is location",
          tags: ["tag1", "tag2", "tag3"]
        },
        {
          id: "3",
          title: "This is title for card",
          content: "this is content for card",
          location: "this is location",
          tags: ["tag1", "tag2", "tag3"]
        },
        {
          id: "3",
          title: "This is title for card",
          content: "this is content for card",
          location: "this is location",
          tags: ["tag1", "tag2", "tag3"]
        },
        {
          id: "3",
          title: "This is title for card",
          content: "this is content for card",
          location: "this is location",
          tags: ["tag1", "tag2", "tag3"]
        },
        {
          id: "3",
          title: "This is title for card",
          content: "this is content for card",
          location: "this is location",
          tags: ["tag1", "tag2", "tag3"]
        },
        {
          id: "3",
          title: "This is title for card",
          content: "this is content for card",
          location: "this is location",
          tags: ["tag1", "tag2", "tag3"]
        }
      ]
    };
  }
};
</script>

<style lang="scss" scoped>
@import "@/scss/global.scss";

.container {
  margin: 60px 60px;
  display: grid;
  grid-template-columns: 1fr 1fr 1fr;
  grid-gap: 20px;

  @media screen and (max-width: 992px) {
    grid-template-columns: 1fr 1fr;
  }

  @media screen and (max-width: 650px) {
    grid-template-columns: 1fr;
  }

  .card {
    display: flex;
    flex-direction: column;
    max-width: 400px;
    min-height: 200px;
    background-color: #fff;
    border: 1px solid #d0d0d0;
    border-radius: 4px;
    margin: 10px;
    text-align: left;
    padding: 30px 30px;
    cursor: pointer;

    .card-title {
      color: #0e75e2;
      margin-bottom: 10px;
    }

    ul {
      margin-top: auto;
    }

    li {
      color: #303030;
      display: inline-block;
      background-color: #f4f4f4;
      padding: 5px 15px;
      border-radius: 20px;
      margin: 0 10px 0 0;
    }
  }
}
</style>
