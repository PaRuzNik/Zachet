import { UserImage } from "./user-image";

export interface User {
  entityId: number;
  userId: number;
  name: string;
  image: UserImage
}

