<template>
  <div class="index container">
    <div class="card" v-for="post in posts" :key="post.id">
      <div class="card-title">
        <h4>{{ post.title }}</h4>
      </div>
      <div class="card-content">{{ post.content }}</div>
      <div class="card-title">{{ post.location }}</div>
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
// import Post from "@/components/Post.vue";

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
.container {
  margin: 60px 60px;
  display: grid;
  grid-template-columns: 1fr 1fr 1fr;
  grid-gap: 20px;

  .card {
    max-width: 100%;
    max-height: 400px;
    background-color: red;
    border-radius: 4px;
    margin: 10px;
    text-align: left;
    padding: 15px;
  }
}
</style>
