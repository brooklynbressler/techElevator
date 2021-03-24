<template>
  <table id="tblUsers">
    <thead>
    <tr>
        <th>First Name</th>
        <th>Last Name</th>
        <th>Username</th>
        <th>Email Address</th>
        <th>Status</th>
    </tr>
    </thead>
    <div ></div>
    <tbody>
      <tr  >
        <td><input type="text" id="firstNameFilter" v-model="filter.firstName"/></td>
        <td><input type="text" id="lastNameFilter" v-model="filter.lastName"/></td>
        <td><input type="text" id="usernameFilter" v-model="filter.username"/></td>
        <td><input type="text" id="emailFilter" v-model="filter.emailAddress"/></td>
        <td>
          <select id="statusFilter"  v-model="filter.status" >
            <option value="">Show All</option>
            <option value="Active">Active</option>
            <option value="Disabled">Disabled</option>
          </select>
        </td>
      </tr>
      <!-- user listing goes here -->
      <tr v-for="user in users" v-bind:key="user" v-bind:class="user.status.toLowerCase()">
        <td>{{user.firstName}}</td>
        <td>{{user.lastName}}</td>
        <td>{{user.username}}</td>
        <td>{{user.emailAddress}}</td>
        <td>{{user.status}}</td>
        
      </tr>
    </tbody>
  </table>
</template>

<script>
export default {
  name: 'user-list',
  data() {
    return {
      users: [
        { firstName: 'John', lastName: 'Smith', username: 'jsmith', emailAddress: 'jsmith@gmail.com', status: 'Active' },
        { firstName: 'Anna', lastName: 'Bell', username: 'abell', emailAddress: 'abell@yahoo.com', status: 'Active' },
        { firstName: 'George', lastName: 'Best', username: 'gbest', emailAddress: 'gbest@gmail.com', status: 'Disabled' },
        { firstName: 'Ben', lastName: 'Carter', username: 'bcarter', emailAddress: 'bcarter@gmail.com', status: 'Active' },
        { firstName: 'Katie', lastName: 'Jackson', username: 'kjackson', emailAddress: 'kjackson@yahoo.com', status: 'Active' },
        { firstName: 'Mark', lastName: 'Smith', username: 'msmith', emailAddress: 'msmith@foo.com', status: 'Disabled' }
      ],
    filter: {
    firstName: '',
  lastName:'',
  username:'',
  emailAddress: '',
  status:'',
} 
}
},
computed:{
  filteredList() {
    if(this.filter.firstName && this.filter.lastName){
    return this.users.filter(user => user.firstName.toLowerCase().includes(this.filter.firstName.toLowerCase()) && 
    user.lastName.toLowerCase().includes(this.filter.lastName.toLowerCase()));
    }
    if(this.filter.firstName){
    return this.users.filter(user => user.firstName.toLowerCase().includes(this.filter.firstName.toLowerCase()));
    }
    if(this.filter.lastName){
      return this.users.filter(user => user.lastName.toLowerCase() === this.filter.lastName.toLowerCase());
    }
    if(this.filter.emailAddress){
    return this.users.filter(user => user.emailAddress.toLowerCase() === this.filter.emailAddress.toLowerCase());
    }
    if(this.filter.username){
      return this.users.filter(user => user.username.toLowerCase() === this.filter.username.toLowerCase());
    }
    if(this.filter.status){
      return this.users.filter(user => user.status.toLowerCase() === this.filter.status.toLowerCase());
    }
    return this.users;
  }
}
}

    


</script>

<style scoped>
table {
  margin-top: 20px;
  font-family:-apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif
}
th {
  text-transform: uppercase
}
td {
  padding: 10px;
}
tr.disabled {
  color: red;
}
input, select {
  font-size: 16px;
}
</style>
