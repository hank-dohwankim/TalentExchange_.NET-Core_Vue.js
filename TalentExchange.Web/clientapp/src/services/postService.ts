import axios from 'axios';

/*
 * Post Service
 */

export class PostService {
  API_URL = process.env.VUE_APP_API_URL;

  public async getPosts(): Promise<any> {
    console.log('getPosts:', this.API_URL);
    let result: any = await axios.get(`${this.API_URL}/post/`);
  }
}
