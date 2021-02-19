import { User } from "./user";

export interface Group {
    id: number;
    title: string;
    users: User[];
  }

export interface GroupsDto {
  groups: Group[];
}