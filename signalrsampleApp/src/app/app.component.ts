import { Component, OnInit } from '@angular/core';
import { HubConnectionBuilder} from '@aspnet/signalr';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {

  title = 'signalrsampleApp';
  connection = new HubConnectionBuilder().withUrl("http://localhost:5000/message").build();

  ngOnInit(): void {
    this.connection.on("topic", data => {
      console.log(`Employee Data = ${data}`);
    });

    this.connection.start().then(() => {
      // connection.invoke('topic', 'Hello');
      console.log("connected");
    });
  }
}
