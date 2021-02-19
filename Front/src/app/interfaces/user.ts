export interface User {
    id: number;
    groupId: number;
    firstName: string;
    lastName: string;
    email: string;
    phoneNumber: string;
  }

export interface UsersDto {
  users: User[];
}