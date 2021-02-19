import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ClientService } from '../client.service';
import { User } from '../interfaces/user';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {

  user!: User;

  constructor(
    private clientService: ClientService,
    private route: ActivatedRoute
    ) { }


  ngOnInit(): void {
    const id = this.route.snapshot.paramMap.get('id');
    this.clientService.getUserById(id)
      .subscribe(user => {this.user = user});
  }
}
