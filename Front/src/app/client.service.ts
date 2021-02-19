import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { UsersDto, User } from './interfaces/user';
import { Observable } from 'rxjs/internal/Observable';
import { catchError, map, tap } from 'rxjs/operators';
import { GroupsDto, Group } from './interfaces/group';

@Injectable({
  providedIn: 'root'
})
export class ClientService {
  private userUrl = 'http://localhost:63359/api/User/';
  private groupUrl = 'http://localhost:63359/api/Group/';

  constructor(private http: HttpClient) { }

  getUsers(): Observable<UsersDto> {
    let data = this.http.get<UsersDto>(this.userUrl + 'GetAllUsers');
    return data;
  }

  getGroups(): Observable<GroupsDto> {
    let data = this.http.get<GroupsDto>(this.groupUrl + 'GetAllGroups');
    return data;
  }

  getUserById(id: string | null): Observable<User> {
    let data = this.http.get<User>(this.userUrl + 'GetUser?Id=' + id);
    return data;
  }

  getGroupById(id: string | null): Observable<Group> {
    let data = this.http.get<Group>(this.groupUrl + 'GetGroup?Id=' + id);
    return data;
  }
}
