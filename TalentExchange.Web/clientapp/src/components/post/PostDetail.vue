<template>
  <section class="layer">
    <div v-if="post" class="container">
      <div class="btn-group back">
        <router-link :to="{ name: 'Index' }">
          <p>뒤로가기</p>
        </router-link>
        <div class="btn-group modifiy">
          <div class="btn-delete">
            <i class="fas fa-trash-alt" v-on:click="DeletePost"></i>
          </div>
        </div>
      </div>
      <form @submit.prevent="EditPost">
        <div class="field title">
          <h1>{{ post.title }}</h1>
        </div>
        <div class="field location">
          <i class="fas fa-map-marker-alt"></i>
          <p>{{ post.location }}</p>
        </div>
        <div class="field category">
          <label>카테고리 :</label>
          <p>{{ post.categoryId }}</p>
        </div>
        <div class="field content">
          <label>의뢰내용 :</label>
          <p>{{ post.content }}</p>
        </div>
        <div class="tag-list">
          <label for="add-tagName">태그 :</label>
          <div class="tagName-chip" v-for="(tagName, index) in post.tags" :key="index">
            <p class="label">{{ tagName.tagName }}</p>
          </div>
        </div>
      </form>
    </div>
  </section>
</template>

<script>
export default {
  name: "PostDetail",

  data() {
    return {
      post: {}
    };
  },
  created() {
    this.$axios
      .get("http://localhost:50598/api/post/" + this.$route.params.post_id)
      .then(result => {
        this.post = result.data;
      });
  },
  methods: {
    GetPostById(postId) {
      this.$axios
        .get("https://localhost:50598/api/post/" + postId)
        .then(result => {
          this.post = result.data;
        });
    },
    async DeletePost() {
      if (this.post.title) {
        this.$axios
          .delete("http://localhost:50598/api/post/" + this.post.id, {
            "content-type": "text/json"
          })
          .then(this.$axios.get("http://localhost:50598"))
          .then(this.$router.push({ name: "Index" }))
          .catch(error => {
            console.log(error.response);
          });
      }
    }
  }
};
</script>

<style lang="scss" scoped>
.layer {
  display: flex;
  flex-direction: row;
  justify-content: center;

  .container {
    margin: 30px;
    padding: 20px;
    width: 75%;
    border: solid lightgrey 2px;
    border-radius: 4px;
    background-color: #fff;

    .field {
      display: flex;
      margin: 20px;

      p {
        margin-left: 10px;
      }
    }

    .btn-delete i {
      cursor: pointer;
    }
  }
}
</style>
