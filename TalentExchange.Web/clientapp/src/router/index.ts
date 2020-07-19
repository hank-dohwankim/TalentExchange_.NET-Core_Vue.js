import Vue from 'vue';
import VueRouter, { RouteConfig } from 'vue-router';
import Index from '../views/Index.vue';

Vue.use(VueRouter);

const routes: Array<RouteConfig> = [
  {
    path: '/',
    name: 'Index',
    component: () => import('@/views/Index.vue'),
  },
  {
    path: '/post/:post_id',
    name: 'PostDetail',
    component: () => import('@/components/post/PostDetail.vue'),
  },
];

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes,
});

export default router;
