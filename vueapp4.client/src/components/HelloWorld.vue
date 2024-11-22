<template>
  <div>
    <h1>{{ message }}</h1>
    <button @click="fetchMessage">Get Message</button>
  </div>
</template>

<script>
  import axios from 'axios';

  export default {
    data() {
      return {
        message: 'Loading...'
      };
    },
    methods: {
      // 这个方法会从后端获取消息
      fetchMessage() {
        axios.get('http://localhost:7150/HelloWorld')
          .then(response => {
            this.message = response.data;  // 更新组件中的 message
          })
          .catch(error => {
            console.error('There was an error fetching the message:', error);
            this.message = 'Failed to load message.';
          });
      }
    }
  };
</script>
