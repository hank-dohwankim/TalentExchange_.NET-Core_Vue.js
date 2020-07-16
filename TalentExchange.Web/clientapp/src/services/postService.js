import axios from 'axios';
/*
 * Post Service
 */
export class PostService {
    constructor() {
        this.API_URL = process.env.VUE_APP_API_URL;
    }
    async getPosts() {
        console.log('getPosts:', this.API_URL);
        let result = await axios.get(`${this.API_URL}/post/`);
    }
}
//# sourceMappingURL=postService.js.map