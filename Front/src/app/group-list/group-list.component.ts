import { Component, OnInit } from '@angular/core';
import { ClientService } from '../client.service';
import { Group } from '../interfaces/group';

@Component({
  selector: 'app-group-list',
  templateUrl: './group-list.component.html',
  styleUrls: ['./group-list.component.css']
})
export class GroupListComponent implements OnInit {

  groups: Group[] = [];

  constructor(private clientService: ClientService) { }

  ngOnInit(): void {
    this.clientService.getGroups()
        .subscribe(groups => {this.groups = groups.groups});
  }
}
