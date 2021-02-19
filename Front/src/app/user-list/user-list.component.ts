import { Component, OnInit } from '@angular/core';
import { ClientService } from '../client.service';
import { User } from '../interfaces/user';

@Component({
  selector: 'app-user-list',
  templateUrl: './user-list.component.html',
  styleUrls: ['./user-list.component.css']
})
export class UserListComponent implements OnInit {

  users: User[] = [];

  constructor(private clientService: ClientService) { }

  ngOnInit(): void {
    this.clientService.getUsers()
        .subscribe(users => {this.users = users.users});
  }

}
