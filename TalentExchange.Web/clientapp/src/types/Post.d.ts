export interface IPost {
  id: number;
  createdOn: Date;
  updatedOn: Date;
  title: string;
  content: string;
  isArchived: boolean;
}

export interface IPostService {
  id: number;
  post: IPost;
  title: string;
  content: string;
  // tags: Array;
}
